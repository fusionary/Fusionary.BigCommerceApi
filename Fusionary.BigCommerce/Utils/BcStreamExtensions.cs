namespace Fusionary.BigCommerce.Utils;

public static class BcStreamExtensions
{
    public static async Task<byte[]> ReadAllBytesAsync(
        this Stream stream,
        CancellationToken cancellationToken = default
    )
    {
        if (stream is MemoryStream contentStream)
        {
            return contentStream.ToArray();
        }

        var memoryStream = new MemoryStream();

        if (stream.CanSeek)
        {
            stream.Seek(0, SeekOrigin.Begin);
        }

        await stream.CopyToAsync(memoryStream, cancellationToken);

        return memoryStream.ToArray();
    }
}