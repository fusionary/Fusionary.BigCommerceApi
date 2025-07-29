using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

using CsvHelper;
using CsvHelper.Configuration;

namespace Fusionary.BigCommerce.Import;

public static class ExportFileReader
{
    public static async IAsyncEnumerable<BcProductCsvRecord> ReadRecordsAsync(
        Stream inputStream,
        Action<CsvConfiguration>? configureBuilder = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        using var streamReader = new StreamReader(inputStream, Encoding.UTF8);

        await foreach (var record in ReadStreamAsync(configureBuilder, streamReader, cancellationToken))
        {
            yield return record;
        }
    }
    
    public static async IAsyncEnumerable<BcProductCsvRecord> ReadRecordsAsync(
        string filePath,
        Action<CsvConfiguration>? configureBuilder = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        using var streamReader = new StreamReader(filePath, Encoding.UTF8);

        await foreach (var record in ReadStreamAsync(configureBuilder, streamReader, cancellationToken))
        {
            yield return record;
        }
    }

    private static async IAsyncEnumerable<BcProductCsvRecord> ReadStreamAsync(
        Action<CsvConfiguration>? configureBuilder,
        StreamReader streamReader,
        [EnumeratorCancellation] CancellationToken cancellationToken
    )
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",", HasHeaderRecord = true, Quote = '"', MissingFieldFound = null
        };
        
        configureBuilder?.Invoke(config);

        using var csvReader = new CsvReader(streamReader, config);

        await csvReader.ReadAsync();
        
        csvReader.ReadHeader();

        await foreach (var record in csvReader.GetRecordsAsync<BcProductCsvRecord>(cancellationToken))
        {
            yield return record;
        }
    }
}