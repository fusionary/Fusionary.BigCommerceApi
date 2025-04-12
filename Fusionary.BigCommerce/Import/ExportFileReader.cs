using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

using CsvHelper;
using CsvHelper.Configuration;

namespace Fusionary.BigCommerce.Import;

public static class ExportFileReader
{
    public static async IAsyncEnumerable<BcProductCsvRecord> ReadRecordsAsync(
        string filePath,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        using var streamReader = new StreamReader(filePath, Encoding.UTF8);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",", HasHeaderRecord = true, Quote = '"', MissingFieldFound = null
        };

        using var csvReader = new CsvReader(streamReader, config);

        await csvReader.ReadAsync();
        csvReader.ReadHeader();

        await foreach (var record in csvReader.GetRecordsAsync<BcProductCsvRecord>(cancellationToken))
        {
            yield return record;
        }
    }
}