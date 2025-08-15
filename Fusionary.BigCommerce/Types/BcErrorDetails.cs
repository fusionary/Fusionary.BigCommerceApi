using System.Runtime.InteropServices.JavaScript;

namespace Fusionary.BigCommerce.Types;

public record BcErrorDetails
{
    public HttpStatusCode Status { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Instance { get; set; }

    [JsonIgnore]
    public bool HasErrorDetails => ErrorDetails?.Count > 0;

    public Dictionary<string, string> ErrorDetails { get; set; } = null!;
    
    public Dictionary<string, string> Errors { get { return ErrorDetails; } set { ErrorDetails = value; } }
}