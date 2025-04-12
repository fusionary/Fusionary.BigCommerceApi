namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{FileName}")]
public record BcFile
{
    public required byte[] Contents { get; init; }

    public required string FileName { get; init; }

    public static async Task<BcFile> ReadFromFileAsync(string filePath, CancellationToken cancellationToken = default)
    {
        var contents = await File.ReadAllBytesAsync(filePath, cancellationToken);
        return new BcFile { FileName = Path.GetFileName(filePath), Contents = contents };
    }

    public static async Task<BcFile> ReadFromStreamAsync(
        Stream stream,
        string fileName,
        CancellationToken cancellationToken = default
    )
    {
        var contents = await stream.ReadAllBytesAsync(cancellationToken);

        return new BcFile { FileName = Path.GetFileName(fileName), Contents = contents };
    }
}