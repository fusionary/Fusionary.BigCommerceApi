namespace Fusionary.BigCommerce;

public class BcOrdersSearch : BcRequestBuilder<BcOrdersSearch>
{
    public BcOrdersSearch(IBigCommerceApi api) : base(api)
    { }

    public BcOrdersSearch CartID(string cartID) => Add(BcOrderFilter.CartId, cartID);

    public BcOrdersSearch ChannelId(string channelId) => Add(BcOrderFilter.ChannelId, channelId);

    public BcOrdersSearch CustomerId(string customerId) => Add(BcOrderFilter.CustomerId, customerId);

    public BcOrdersSearch Email(string email) => Add(BcOrderFilter.Email, email);

    public BcOrdersSearch IsDeleted(bool isDeleted) => Add(BcOrderFilter.IsDeleted, isDeleted);

    public BcOrdersSearch Limit(int limit) => Add(BcOrderFilter.Limit, limit);

    public BcOrdersSearch MinId(int id) => Add(BcOrderFilter.MinId, id);

    public BcOrdersSearch MaxId(int id) => Add(BcOrderFilter.MaxId, id);

    public BcOrdersSearch MinTotal(decimal total) => Add(BcOrderFilter.MinTotal, total);

    public BcOrdersSearch MaxTotal(decimal total) => Add(BcOrderFilter.MaxTotal, total);

    public BcOrdersSearch MaxDateCreated(DateOnly date) => Add(BcOrderFilter.MaxDateCreated, date);

    public BcOrdersSearch MaxDateModified(DateOnly date) => Add(BcOrderFilter.MaxDateModified, date);

    public BcOrdersSearch MinDateCreated(DateOnly date) => Add(BcOrderFilter.MinDateCreated, date);

    public BcOrdersSearch MinDateModified(DateOnly date) => Add(BcOrderFilter.MinDateModified, date);

    public BcOrdersSearch PaymentMethod(string paymentMethod) => Add(BcOrderFilter.PaymentMethod, paymentMethod);

    public BcOrdersSearch Page(int page) => Add(BcOrderFilter.Page, page);

    public BcOrdersSearch Sort(BcOrderSort sort) => Add(BcOrderFilter.Sort, sort.ToValue());

    public BcOrdersSearch StatusId(int statusId) => Add(BcOrderFilter.StatusId, statusId);

    public Task<BcObject[]> SendAsync(CancellationToken cancellationToken) => SendAsync<BcObject>(cancellationToken);

    public async Task<TOrder[]> SendAsync<TOrder>(CancellationToken cancellationToken) =>
        await Api.GetAsync<TOrder[]>(
            BcEndpoint.OrdersV2(),
            Filter,
            cancellationToken
        );
}