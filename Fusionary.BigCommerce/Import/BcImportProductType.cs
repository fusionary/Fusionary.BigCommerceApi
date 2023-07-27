namespace Fusionary.BigCommerce.Import;

public static class BcImportProductType
{
    /// <summary>
    /// Exist in a physical form, have a weight, and are sold by merchants to ship to customers
    /// </summary>
    public static readonly string Physical = "Physical";

    /// <summary>
    /// Non-physical products, including downloadable files (for example, computer software, ebooks, or music) and services
    /// (for example, haircuts, consulting, or lawn care).
    /// </summary>
    public static readonly string Digital = "Digital";
}
