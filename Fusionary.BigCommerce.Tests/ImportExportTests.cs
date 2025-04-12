using Fusionary.BigCommerce.Import;

namespace Fusionary.BigCommerce.Tests;

public class ImportExportTests : BcTestBase
{
    [Test]
    public async Task Can_Read_Export_File_Async()
    {
        const string fileName = "v3-product-import-template.csv";

        await foreach (var record in ExportFileReader.ReadRecordsAsync(fileName))
        {
            DumpObject(record);

            if (!string.IsNullOrWhiteSpace(record.Options))
            {
                var options = BcImportPipeDelimitedList.Parse(record.Options);

                DumpObject(options);
            }

            if (!string.IsNullOrWhiteSpace(record.CustomFields))
            {
                var customFields = BcImportCustomFieldList.Parse(record.CustomFields);

                DumpObject(customFields);
            }
        }

        Assert.Pass();
    }
}