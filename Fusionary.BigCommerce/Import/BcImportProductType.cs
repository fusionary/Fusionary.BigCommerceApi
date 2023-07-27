namespace Fusionary.BigCommerce.Import;

public enum BcImportProductType
{
    /// <summary>
    /// Exist in a physical form, have a weight, and are sold by merchants to ship to customers
    /// </summary>
    Physical,

    /// <summary>
    /// Non-physical products, including downloadable files (for example, computer software, ebooks, or music) and services
    /// (for example, haircuts, consulting, or lawn care).
    /// </summary>
    Digital
}

public enum BcImportInventoryTracking
{
    None,
    Product,
    Variant
}

public enum BcImportCondition
{
    New,
    Used,
    Refurbished
}
