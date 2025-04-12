namespace Fusionary.BigCommerce.Operations;

public class Authentication
{
    [JsonPropertyName("force_password_reset")]
    public bool? ForcePasswordReset { get; set; }
}