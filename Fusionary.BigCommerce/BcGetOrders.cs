using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce;

public class BcGetOrders : BcRequestBuilder<BcGetOrders>
{
    public BcGetOrders(IBigCommerceApi api, QueryString queryString) : base(api, queryString)
    { }

    public BcGetOrders CartID(string cartID) => Add(BcOrderFilter.CartId, cartID);

    public BcGetOrders ChannelId(string channelId) => Add(BcOrderFilter.ChannelId, channelId);

    public BcGetOrders CustomerId(string customerId) => Add(BcOrderFilter.CustomerId, customerId);

    public BcGetOrders Email(string email) => Add(BcOrderFilter.Email, email);

    public BcGetOrders IsDeleted(bool isDeleted) => Add(BcOrderFilter.IsDeleted, isDeleted);

    public BcGetOrders Limit(int limit) => Add(BcOrderFilter.Limit, limit);

    public BcGetOrders MinId(int id) => Add(BcOrderFilter.MinId, id);

    public BcGetOrders MaxId(int id) => Add(BcOrderFilter.MaxId, id);

    public BcGetOrders MinTotal(decimal total) => Add(BcOrderFilter.MinTotal, total);

    public BcGetOrders MaxTotal(decimal total) => Add(BcOrderFilter.MaxTotal, total);

    public BcGetOrders MaxDateCreated(DateOnly date) => Add(BcOrderFilter.MaxDateCreated, date);

    public BcGetOrders MaxDateModified(DateOnly date) => Add(BcOrderFilter.MaxDateModified, date);

    public BcGetOrders MinDateCreated(DateOnly date) => Add(BcOrderFilter.MinDateCreated, date);

    public BcGetOrders MinDateModified(DateOnly date) => Add(BcOrderFilter.MinDateModified, date);

    public BcGetOrders PaymentMethod(string paymentMethod) => Add(BcOrderFilter.PaymentMethod, paymentMethod);

    public BcGetOrders Page(int page) => Add(BcOrderFilter.Page, page);

    public BcGetOrders Sort(BcOrderSort sort) => Add(BcOrderFilter.Sort, sort.ToValue());

    public BcGetOrders StatusId(int statusId) => Add(BcOrderFilter.StatusId, statusId);

    public Task<BcObject[]> SendAsync(CancellationToken cancellationToken) => SendAsync<BcObject>(cancellationToken);

    public async Task<TOrder[]> SendAsync<TOrder>(CancellationToken cancellationToken) =>
        await Api.GetAsync<TOrder[]>(
            BcEndpoint.OrdersV2(),
            Filter,
            cancellationToken
        );
}