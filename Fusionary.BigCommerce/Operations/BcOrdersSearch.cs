namespace Fusionary.BigCommerce.Operations;

public record BcOrdersSearch : BcRequestBuilder<BcOrdersSearch>, IBcPageableFilter
{
    public BcOrdersSearch(IBigCommerceApi api) : base(api)
    { }

    public Task<BcDataResult<List<BcOrderResponseFull>>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(cancellationToken);

    public async Task<BcDataResult<List<T>>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrdersV2(),
            Filter,
            cancellationToken
        );

    #region Filters

    public BcOrdersSearch CartId(object cartId) => Add("cart_id", cartId);

    public BcOrdersSearch ChannelId(object channelId) => Add("channel_id", channelId);

    public BcOrdersSearch CustomerId(object customerId) => Add("customer_id", customerId);

    public BcOrdersSearch Email(string email) => Add("email", email);

    public BcOrdersSearch IsDeleted(bool isDeleted) => Add("is_deleted", isDeleted);

    public BcOrdersSearch MaxDateCreated(BcDateTime date) => Add("max_date_created", date);

    public BcOrdersSearch MaxDateModified(BcDateTime date) => Add("max_date_modified", date);

    public BcOrdersSearch MaxId(int id) => Add("max_id", id);

    public BcOrdersSearch MaxTotal(decimal total) => Add("max_total", total);

    public BcOrdersSearch MinDateCreated(BcDateTime date) => Add("min_date_created", date);

    public BcOrdersSearch MinDateModified(BcDateTime date) => Add("min_date_modified", date);

    public BcOrdersSearch MinId(int id) => Add("min_id", id);

    public BcOrdersSearch MinTotal(decimal total) => Add("min_total", total);

    public BcOrdersSearch PaymentMethod(string paymentMethod) => Add("payment_method", paymentMethod);

    public BcOrdersSearch Sort(BcOrderSort sort) => Add("sort", sort.ToValue());

    public BcOrdersSearch StatusId(int statusId) => Add("status_id", statusId);

    #endregion
}