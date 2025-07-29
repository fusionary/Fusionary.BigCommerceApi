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
        Action<CsvConfiguration>? configureBuilder = null,
        CancellationToken cancellationToken = default
    )
    {
        await using var streamWriter = new StreamWriter(filePath, false, Encoding.UTF8);

        await WriteToStreamAsync(streamWriter, records, configureBuilder, cancellationToken);
    }
    
    [UsedImplicitly]
    public static async Task WriteRecordsAsync(
        Stream outputStream,
        IAsyncEnumerable<BcProductCsvRecord> records,
        Action<CsvConfiguration>? configureBuilder = null,
        CancellationToken cancellationToken = default
    )
    {
        await using var streamWriter = new StreamWriter(outputStream, Encoding.UTF8);

        await WriteToStreamAsync(streamWriter, records, configureBuilder, cancellationToken);
    }

    private static async Task WriteToStreamAsync(
        StreamWriter streamWriter,
        IAsyncEnumerable<BcProductCsvRecord> records,
        Action<CsvConfiguration>? configureBuilder,
        CancellationToken cancellationToken
    )
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",", HasHeaderRecord = true, Quote = '"'
        };
        
        configureBuilder?.Invoke(config);

        await using var csvWriter = new CsvWriter(streamWriter, config);

        await csvWriter.WriteRecordsAsync(records, cancellationToken);
    }
}