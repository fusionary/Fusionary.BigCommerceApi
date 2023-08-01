using System.ComponentModel;

namespace Fusionary.BigCommerce.Types;

public record BcCategoryTreePostItem : BcCategoryPost
{
    [JsonPropertyName("tree_id")]
    public int TreeId { get; set; }

    [JsonPropertyName("default_product_sort")]
    public BcDefaultProductSort? DefaultProductSort { get; set; } = BcDefaultProductSort.UseStoreSettings;

    /// <summary>
    /// The custom URL for the category on the storefront.
    /// </summary>
    [JsonPropertyName("url")]
    public BcCustomPath? Url { get; set; }

    /// <summary>
    /// API Consistency Anyone?
    /// </summary>
    // ReSharper disable once UnusedMember.Local
    [EditorBrowsable(EditorBrowsableState.Never)]
    private new BcCustomUrl? CustomUrl { get; set; }
}