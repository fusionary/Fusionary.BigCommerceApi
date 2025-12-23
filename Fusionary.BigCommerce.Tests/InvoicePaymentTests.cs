using Fusionary.BigCommerce.B2B.Operations;
using Fusionary.BigCommerce.B2B.Types;
using Fusionary.BigCommerce.Types;

namespace Fusionary.BigCommerce.Tests;

public class InvoicePaymentTests : BcTestBase
{
    [Test]
    [Explicit]
    public async Task Can_Create_Offline_PaymentAsync()
    {
        var createApi = Services.GetRequiredService<B2BApiInvoicePaymentCreate>();
        var getApi = Services.GetRequiredService<B2BApiInvoiceGet>();

        // Get unpaid invoices (status 0 = Open)
        var invoicesResult = await getApi
            .Add("isIncludeExtraFields", "1")
            .Add("limit", "100")
            .Add("status", "0")
            .SendAsync(CancellationToken.None);

        if (invoicesResult is not { HasData: true, Data.Count: > 0 })
        {
            Assert.Inconclusive("No invoices available to test with");
            return;
        }

        // Debug: print all invoices and their open balance
        Console.WriteLine($"Found {invoicesResult.Data.Count} invoices:");
        foreach (var inv in invoicesResult.Data.Take(500))
        {
            Console.WriteLine($"  Invoice {inv.Id} ({inv.InvoiceNumber}): OpenBalance = {inv.OpenBalance?.Value ?? "null"} {inv.OpenBalance?.CurrencyCode ?? ""}");
        }

        // Find an invoice with a positive open balance
        var invoice = invoicesResult.Data.FirstOrDefault(i =>
            i.OpenBalance?.Value != null &&
            decimal.TryParse(i.OpenBalance.Value, out var balance) &&
            balance > 0);

        if (invoice == null)
        {
            Assert.Inconclusive("No invoices with open balance available to test with");
            return;
        }

        var openBalance = decimal.Parse(invoice.OpenBalance!.Value!);
        var paymentAmount = Math.Min(openBalance, 1.00m); // Pay $1 or full balance if less
        var currency = invoice.OpenBalance.CurrencyCode ?? "USD";

        Console.WriteLine($"Using invoice ID: {invoice.Id}, Number: {invoice.InvoiceNumber}");
        Console.WriteLine($"Open Balance: {openBalance} {currency}");
        Console.WriteLine($"Payment Amount: {paymentAmount}");

        var request = new B2BInvoicePaymentCreateRequest
        {
            LineItems =
            [
                new B2BInvoicePaymentCreateLineItem
                {
                    InvoiceId = invoice.Id!.Value,
                    Amount = paymentAmount.ToString("F2")
                }
            ],
            Currency = currency,
            Details = new B2BInvoicePaymentDetails { Memo = "Test payment from unit test" },
            CustomerId = invoice.CustomerId!,
            PayerName = "Test Payer",
            ProcessingStatus = 2 // Processing
        };

        var result = await createApi.SendAsync(request, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Created payment with ID: {result.Data.PaymentId}");
            Assert.Pass();
        }
    }


    [Test]
    [Explicit]
    public async Task Can_Get_All_PaymentsAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoicePaymentGet>();

        var result = await api.SendAsync(CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Found {result.Data.Count} payments");
            foreach (var payment in result.Data.Take(5))
            {
                Console.WriteLine($"  Payment ID: {payment.Id}, Status: {payment.ProcessingStatus}, Amount: {payment.Total?.Value} {payment.Total?.CurrencyCode}");
            }
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Get_Processing_PaymentsAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoicePaymentGet>();

        var result = await api
            .Add("processingStatus", "2")
            .SendAsync(CancellationToken.None);
        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Found {result.Data.Count} payments with processing status 2");
            foreach (var payment in result.Data)
            {
                Console.WriteLine($"  Payment ID: {payment.Id}, Customer: {payment.CustomerName}, Amount: {payment.Total?.Value}");
                if (payment.LineItems != null)
                {
                    foreach (var lineItem in payment.LineItems)
                    {
                        Console.WriteLine($"    -> Invoice ID: {lineItem.InvoiceId}, Amount: {lineItem.Amount?.Value}");
                    }
                }
            }
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Get_Payment_By_IdAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoicePaymentGet>();

        // First get all payments to find a valid ID
        var allResult = await api.SendAsync(CancellationToken.None);

        if (allResult is not { HasData: true, Data.Count: > 0 })
        {
            Assert.Inconclusive("No payments available to test with");
            return;
        }

        var firstPaymentId = allResult.Data[0].Id!.Value;
        Console.WriteLine($"Testing with payment ID: {firstPaymentId}");

        var result = await api.SendAsync(firstPaymentId, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            var payment = result.Data;
            Console.WriteLine($"Payment Details:");
            Console.WriteLine($"  ID: {payment.Id}");
            Console.WriteLine($"  Customer: {payment.CustomerName}");
            Console.WriteLine($"  Payer: {payment.PayerName}");
            Console.WriteLine($"  Module: {payment.ModuleName}");
            Console.WriteLine($"  Processing Status: {payment.ProcessingStatus}");
            Console.WriteLine($"  Applied Status: {payment.AppliedStatus}");
            Console.WriteLine($"  Funding Status: {payment.FundingStatus}");
            Console.WriteLine($"  Total: {payment.Total?.Value} {payment.Total?.CurrencyCode}");
            Console.WriteLine($"  Created: {payment.CreatedAt}");
            Console.WriteLine($"  Line Items: {payment.LineItems?.Count ?? 0}");
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Update_Payment_Processing_StatusAsync()
    {
        var getApi = Services.GetRequiredService<B2BApiInvoicePaymentGet>();
        var updateApi = Services.GetRequiredService<B2BApiInvoicePaymentUpdateStatus>();

        // First get a payment with status 2 (Processing) to test with
        var allResult = await getApi
            .Add("processingStatus", "2")
            .SendAsync(CancellationToken.None);

        if (allResult is not { HasData: true, Data.Count: > 0 })
        {
            Assert.Inconclusive("No payments with status 2 available to test with");
            return;
        }

        var paymentId = allResult.Data[0].Id!.Value;
        Console.WriteLine($"Testing with payment ID: {paymentId}");

        // Update to status 3 (Completed) - simulating GP sync completion
        var statusUpdate = new B2BInvoicePaymentStatusUpdate { ProcessingStatus = 3 };
        var result = await updateApi.SendAsync(paymentId, statusUpdate, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Updated payment {paymentId} processing status to 3 (Completed)");
            Assert.Pass();
        }
    }
}
