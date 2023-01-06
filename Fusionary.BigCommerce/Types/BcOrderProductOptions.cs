namespace Fusionary.BigCommerce.Types;

public record BcOrderProductOptions
{
    /// <summary>
    /// The unique numerical ID of the option; increments sequentially.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Numeric ID of the associated option.
    /// </summary>
    public int OptionId { get; set; }

    /// <summary>
    /// Numeric ID of the associated product.
    /// </summary>
    public int OrderProductId { get; set; }

    /// <summary>
    /// Numeric ID of an option applied to the product from a list of options available to the product.
    /// </summary>
    public int ProductOptionId { get; set; }

    /// <summary>
    /// Alias for display_name_customer. The product option name that is shown to customer in the storefront.
    /// </summary>
    public string DisplayName { get; set; } = null!;

    /// <summary>
    /// The product option name that is shown to customer in storefront.
    /// </summary>
    public string DisplayNameCustomer { get; set; } = null!;

    /// <summary>
    /// The product option name that is shown to merchant in Control Panel.
    /// </summary>
    public string DisplayNameMerchant { get; set; } = null!;

    /// <summary>
    /// Alias for display_value_customer. The product option value that is shown to customer in storefront.
    /// </summary>
    public string DisplayValue { get; set; } = null!;

    /// <summary>
    /// The product option value that is shown to customer in storefront.
    /// </summary>
    public string? DisplayValueCustomer { get; set; }

    /// <summary>
    /// The product option value that is shown to merchant in Control Panel.
    /// </summary>
    public string? DisplayValueMerchant { get; set; }

    /// <summary>
    /// This value is used to access the Customer File Upload
    /// </summary>
    public string Value { get; set; } = null!;

    /// <summary>
    /// Option Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// The option’s name, as used internally. Must be unique.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// How it is displayed on the storefront. Examples include Drop-down, radio buttons, or rectangles.
    /// </summary>
    public string DisplayStyle { get; set; } = null!;
}