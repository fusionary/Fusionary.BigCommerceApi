using System.Net;

namespace Fusionary.BigCommerce.Operations;

public record BcOrderMetafieldDelete : BcRequestBuilder<BcProductDelete>
{
    public BcOrderMetafieldDelete(IBigCommerceApi api) : base(api)
    { }

    public Task<BcResult> SendAsync(object orderId, object metafieldId, CancellationToken cancellationToken) =>
        Api.DeleteAsync(BcEndpoint.OrdersMetafieldsV3(orderId, metafieldId), Filter, cancellationToken);

    public async Task<BcResult> SendAsync(object orderId, IEnumerable<object> metafieldIds, CancellationToken cancellationToken)
    {
        foreach (var metafieldId in metafieldIds)
        {
           var result = await Api.DeleteAsync(BcEndpoint.OrdersMetafieldsV3(orderId, metafieldId), Filter, cancellationToken);

           if (!result.Success)
           {
               return result;
           }
        }

        return new BcResult
        {
            Success = true,
            StatusCode = HttpStatusCode.NoContent,
            ResponseText = "Metafields deleted"
        };
    }
}