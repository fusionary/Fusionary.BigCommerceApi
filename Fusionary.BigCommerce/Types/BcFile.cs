namespace Fusionary.BigCommerce.Types;

[DebuggerDisplay("{FileName}")]
public record BcFile
{
    public byte[] Contents { get; init; } = null!;

    public string FileName { get; init; } = null!;

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