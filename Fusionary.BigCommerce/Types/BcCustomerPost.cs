namespace Fusionary.BigCommerce.Types;

public class BcCustomerPost : BcCustomer
{
    [JsonPropertyName("trigger_account_created_notification")]
    public bool TriggerAccountCreatedNotification { get; set; } = false;
}