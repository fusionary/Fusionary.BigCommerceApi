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
        var invoiceId = 8992368; // Replace with a valid invoice ID

        var result = await api.SendAsync(invoiceId, CancellationToken.None);

        Console.WriteLine($"StatusCode: {result.StatusCode}");
        Console.WriteLine($"ResponseText: {result.ResponseText}");

        if (result.HasData)
        {
            Console.WriteLine($"Invoice: {result.Data.InvoiceNumber}");
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
            DueDateTimestamp = (int)DateTimeOffset.UtcNow.AddDays(30).ToUnixTimeSeconds(),
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
}
