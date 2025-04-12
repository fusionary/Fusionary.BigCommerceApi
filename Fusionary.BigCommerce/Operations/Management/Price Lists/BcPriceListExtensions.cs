namespace Fusionary.BigCommerce.Operations;

public static class BcPriceListExtensions
{
    public static T PriceList<T>(this T builder, BcId priceListId) where T : IBcPriceListFilter =>
        builder.Add("price_list_id", priceListId.Value);

    public static T PriceList<T>(this T builder, IEnumerable<BcId> priceListIds) where T : IBcPriceListFilter =>
        builder.Add("price_list_id:in", priceListIds.Select(x => x.Value));
}