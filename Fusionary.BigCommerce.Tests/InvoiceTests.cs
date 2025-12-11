using Fusionary.BigCommerce.B2B.Operations;
using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.Tests;

public class InvoiceTests : BcTestBase
{
    [Test]
    public async Task Can_Get_All_InvoicesAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceGet>();

        var result = await api.SendAsync(CancellationToken.None);

        if (!result.HasError && result.HasData)
        {
            DumpObject(result.Data);
            Assert.Pass();
        }
    }

    [Test]
    public async Task Can_Get_All_Invoices_With_ExtraFieldsAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceGet>();

        var result = await api
            .Add("isIncludeExtraFields", "1")
            .SendAsync(CancellationToken.None);
        
        Console.WriteLine(result.ResponseText);

        if (!result.HasError && result.HasData)
        {
            DumpObject(result.Data);
            Assert.Pass();
        }
    }

    [Test]
    public async Task Can_Get_Invoice_By_IdAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceGet>();
        // var invoiceId = 8724404; // Replace with a valid invoice ID for your test environment
        var invoiceId = "8780311";

        var result = await api.SendAsync(invoiceId, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"HasError: {result.HasError}");
        Console.WriteLine($"HasData: {result.HasData}");
        Console.WriteLine($"Error: {result.Error?.Title}");
        Console.WriteLine($"Error Details: {result.Error?.ErrorDetails?.GetValueOrDefault("Exception")}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            DumpObject(result.Data);
            Assert.That(result.Data.Id, Is.Not.Null);
            Assert.That(result.Data.InvoiceNumber, Is.Not.Null);
            Assert.Pass();
        }
    }

    [Test]
    public async Task Can_Create_InvoiceAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceCreate>();

        // Use a known customerId from your BC environment
        var customerId = "8818692"; // Christian Assembly from previous tests

        var invoice = new B2BInvoice
        {
            CustomerId = customerId,
            InvoiceNumber = $"{DateTime.UtcNow:MMddHHmmss}",
            DueDateTimestamp = (int)DateTimeOffset.UtcNow.AddDays(30).ToUnixTimeSeconds(),
            Status = 0, // Open
            originalBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "100.00" },
            openBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "100.00" }
        };

        var result = await api.SendAsync(invoice, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"HasError: {result.HasError}");
        Console.WriteLine($"HasData: {result.HasData}");
        Console.WriteLine($"Error: {result.Error?.Title}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            DumpObject(result.Data);
            Assert.That(result.Data.Id, Is.Not.Null);
            Assert.Pass();
        }
    }

    [Test]
    public async Task Can_Create_Invoice_With_OrderAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceCreate>();

        // Christian Assembly customer and order 262
        var customerId = "8818692";
        var orderNumber = 262;

        var invoice = new B2BInvoice
        {
            CustomerId = customerId,
            OrderNumber = orderNumber,
            InvoiceNumber = $"ORD262-{DateTime.UtcNow:MMddHHmmss}",
            DueDateTimestamp = (int)DateTimeOffset.UtcNow.AddDays(30).ToUnixTimeSeconds(),
            Status = 0, // Open
            originalBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "100.00" },
            openBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "100.00" }
        };

        var result = await api.SendAsync(invoice, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"HasError: {result.HasError}");
        Console.WriteLine($"HasData: {result.HasData}");
        Console.WriteLine($"Error: {result.Error?.Title}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            DumpObject(result.Data);
            Assert.That(result.Data.Id, Is.Not.Null);
            Assert.Pass();
        }
    }

    [Test]
    public async Task Can_Update_InvoiceAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceUpdate>();

        // Update invoice 8780074 (TEST-20251211205045)
        var invoiceId = 8780074;
        var invoice = new B2BInvoice
        {
            CustomerId = "8818692",
            openBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "50.00" } // Change from 100 to 50
        };

        var result = await api.SendAsync(invoiceId, invoice, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"HasError: {result.HasError}");
        Console.WriteLine($"HasData: {result.HasData}");
        Console.WriteLine($"Error: {result.Error?.Title}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            DumpObject(result.Data);

            // Verify the update by fetching the invoice
            var getApi = Services.GetRequiredService<B2BApiInvoiceGet>();
            var getResult = await getApi.SendAsync(invoiceId, CancellationToken.None);

            Console.WriteLine($"\nVerifying update:");
            Console.WriteLine($"openBalance: {getResult.Data?.openBalance?.Value}");

            Assert.That(getResult.Data?.openBalance?.Value, Is.EqualTo("50.0000"));
            Assert.Pass();
        }
    }
}