using System.Net;

namespace Fusionary.BigCommerce.Types;

public record BcErrorBase
{
    public HttpStatusCode Status { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;
}