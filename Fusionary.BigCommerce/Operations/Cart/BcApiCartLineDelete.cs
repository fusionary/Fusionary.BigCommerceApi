namespace Fusionary.BigCommerce.Operations
{
    public class BcApiCartDeleteItem : BcRequestBuilder, IBcApiOperation
    {
        public BcApiCartDeleteItem(IBcApi api) : base(api)
        {
            this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");

        }

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
                       BcResultData<BcCartResponseFull> cartResponse2 = await Api.GetDataAsync<BcCartResponseFull>(
                       BcEndpoint.CartV3(cartId),
                        Filter,
                        Options,
                        cancellationToken
                    );

                        if (cartResponse2.Success)
                        {
                            return cartResponse2; // return 200 with BcCartResponseFull
                        }
                    }
                }
            }
            
             return deleteResult; // return 400 Bad Request
            
        }
          
        }
    
}
