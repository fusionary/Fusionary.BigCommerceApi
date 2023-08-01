namespace Fusionary.BigCommerce.Types;

public record BcSuccessNoContentResponse
{
    public int Total { get; set; }
    public int Success { get; set; }
    public int Failed { get; set; }
}