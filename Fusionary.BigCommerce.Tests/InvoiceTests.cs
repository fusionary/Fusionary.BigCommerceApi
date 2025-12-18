using Fusionary.BigCommerce.B2B.Operations;
using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.Tests;

public class InvoiceTests : BcTestBase
{
    [Test]
    [Explicit]
    public async Task Can_Get_Invoice_By_IdAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceGet>();
        var invoiceId = 8992720; // WEB00001009

        var result = await api.SendAsync(invoiceId, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Invoice Number: {result.Data.InvoiceNumber}");
            Console.WriteLine($"IssuedAt: {result.Data.IssuedAt}");
            Console.WriteLine($"DueDate: {result.Data.DueDate}");
            Console.WriteLine($"CreatedAt: {result.Data.CreatedAt}");
            Console.WriteLine($"UpdatedAt: {result.Data.UpdatedAt}");
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Get_All_InvoicesAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceGet>();

        var result = await api
            .Add("isIncludeExtraFields", "1")
            .SendAsync(CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Found {result.Data.Count} invoices");
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Create_InvoiceAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceCreate>();

        var invoice = new B2BInvoice
        {
            CustomerId = "8818692",
            InvoiceNumber = $"TEST-{DateTime.UtcNow:MMddHHmmss}",
            DueDate = DateTimeOffset.UtcNow.AddMonths(1),
            IssuedAt = DateTimeOffset.UtcNow.AddMonths(-1),
            CreatedAt = DateTimeOffset.UtcNow,
            Status = 0,
            originalBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "100.00" },
            openBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "100.00" }
        };

        var result = await api.SendAsync(invoice, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Created invoice with ID: {result.Data.Id}");
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Update_InvoiceAsync()
    {
        var api = Services.GetRequiredService<B2BApiInvoiceUpdate>();

        var invoiceId = 8992368; // Replace with a valid invoice ID
        var invoice = new B2BInvoice
        {
            CustomerId = "8818692",
            openBalance = new B2BMoneyAmount { CurrencyCode = "USD", Value = "50.00" }
        };

        var result = await api.SendAsync(invoiceId, invoice, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Updated invoice {invoiceId}");
            Assert.Pass();
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Delete_InvoiceAsync()
    {
        var deleteApi = Services.GetRequiredService<B2BApiInvoiceDelete>();

        var invoiceId = 8992368; // Replace with a valid invoice ID

        var result = await deleteApi.SendAsync(invoiceId, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
        {
            Console.WriteLine($"Deleted invoice {invoiceId}");
            Assert.Pass();
        }
        else
        {
            Assert.Fail($"Delete failed: {result.ResponseText}");
        }
    }

    [Test]
    [Explicit]
    public async Task Can_Delete_All_InvoicesAsync()
    {
        var getApi = Services.GetRequiredService<B2BApiInvoiceGet>();
        var deleteApi = Services.GetRequiredService<B2BApiInvoiceDelete>();

        // Get all invoices
        var getResult = await getApi.SendAsync(CancellationToken.None);

        if (!getResult.HasData || getResult.Data.Count == 0)
        {
            Console.WriteLine("No invoices to delete");
            Assert.Pass();
            return;
        }

        var invoiceIds = getResult.Data
            .Where(i => i.Id.HasValue)
            .Select(i => i.Id!.Value.Value)
            .ToList();

        Console.WriteLine($"Found {invoiceIds.Count} invoices to delete");

        var deletedCount = 0;
        var failedCount = 0;

        foreach (var invoiceId in invoiceIds)
        {
            var result = await deleteApi.SendAsync(invoiceId, CancellationToken.None);

            if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                deletedCount++;
                Console.WriteLine($"Deleted invoice {invoiceId}");
            }
            else
            {
                failedCount++;
                Console.WriteLine($"Failed to delete invoice {invoiceId}: {result.ResponseText}");
            }
        }

        Console.WriteLine($"Deleted {deletedCount} invoices, {failedCount} failures");
        Assert.That(failedCount, Is.EqualTo(0), $"Failed to delete {failedCount} invoices");
    }
}
