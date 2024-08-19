using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusionary.BigCommerce.Operations.Cart
{

    public class BcApiCartUpdateLine : BcRequestBuilder, IBcApiOperation
    {
        public BcApiCartUpdateLine(IBcApi api) : base(api)
        {
            this.Add("include", "line_items.physical_items.options,shipping_address,shipping_lines");

        }



        public Task<BcResultData<BcCartResponseFull>> SendAsync(
      string cartId,
      string lineId,
      object cartItem,
      CancellationToken cancellationToken = default
  ) =>
      SendAsync<BcCartResponseFull>(cartId, lineId, cartItem, cancellationToken);

        public async Task<BcResultData<T>> SendAsync<T>(string cartId, string lineId, object cartItems, CancellationToken cancellationToken = default) =>
            await Api.PutDataAsync<T>(
                BcEndpoint.CartLineItemV3(cartId,lineId),
                cartItems,
                Filter,
                Options,
                cancellationToken
            );
    }
}
