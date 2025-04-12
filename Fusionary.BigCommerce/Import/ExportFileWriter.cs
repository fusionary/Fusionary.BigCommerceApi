using System.Globalization;
using System.Text;

using CsvHelper;
using CsvHelper.Configuration;

namespace Fusionary.BigCommerce.Import;

public static class ExportFileWriter
{
    [UsedImplicitly]
    public static async Task WriteRecordsAsync(
        string filePath,
        IAsyncEnumerable<BcProductCsvRecord> records,
        CancellationToken cancellationToken
    )
    {
        await using var streamWriter = new StreamWriter(filePath, false, Encoding.UTF8);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",", HasHeaderRecord = true, Quote = '"'
        };

        await using var csvWriter = new CsvWriter(streamWriter, config);

        await csvWriter.WriteRecordsAsync(records, cancellationToken);
    }
}