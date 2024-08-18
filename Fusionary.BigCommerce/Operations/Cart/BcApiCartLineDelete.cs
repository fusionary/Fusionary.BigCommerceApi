namespace Fusionary.BigCommerce.Operations
{
    public class BcApiCartDeleteItem : BcRequestBuilder, IBcApiOperation
    {
        public BcApiCartDeleteItem(IBcApi api) : base(api)
        { }

        public async Task<Object> SendAsync(
            string cartId,
            string lineId,
            CancellationToken cancellationToken = default)
        {
            // Attempt to delete the item
            var deleteResult = await Api.DeleteAsync(
                BcEndpoint.CartLineItemV3(cartId, lineId),
                Filter,
                Options,
                cancellationToken
            );
              
            if (deleteResult.Success)
            {
                // If the response indicates that all items are deleted (204 No Content)
                if (deleteResult.StatusCode == HttpStatusCode.NoContent)
                {
                    return deleteResult; // return 204 No Content
                }
                else
                {

                    var cartResponse = deleteResult as BcResultData<BcCartResponseFull>;

                    if (cartResponse != null)
                    {
                        return cartResponse;
                    }
                    else
                    {
                        // If items still exist, get the cart response
                        BcResultData<BcCartResponseFull> cartResponse = await Api.GetDataAsync<BcCartResponseFull>(
                       BcEndpoint.CartV3(cartId),
                        Filter,
                        Options,
                        cancellationToken
                    );

                        if (cartResponse.Success)
                        {
                            return cartResponse; // return 200 with BcCartResponseFull
                        }
                    }
                }
            }
            
             return deleteResult; // return 400 Bad Request
            
        }
          
        }
    
}
