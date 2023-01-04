namespace Fusionary.BigCommerce.Operations;

public record BcOrdersSearch : BcRequestBuilder<BcOrdersSearch>, IBcPageableFilter
{
    public BcOrdersSearch(IBigCommerceApi api) : base(api)
    { }

    public BcOrdersSearch CartId(string cartId) => Add("cart_id", cartId);

    public BcOrdersSearch ChannelId(string channelId) => Add("channel_id", channelId);

    public BcOrdersSearch CustomerId(string customerId) => Add("customer_id", customerId);

    public BcOrdersSearch Email(string email) => Add("email", email);

    public BcOrdersSearch IsDeleted(bool isDeleted) => Add("is_deleted", isDeleted);

    public BcOrdersSearch MaxDateCreated(DateOnly date) => Add("max_date_created", date);

    public BcOrdersSearch MaxDateModified(DateOnly date) => Add("max_date_modified", date);

    public BcOrdersSearch MaxId(int id) => Add("max_id", id);

    public BcOrdersSearch MaxTotal(decimal total) => Add("max_total", total);

    public BcOrdersSearch MinDateCreated(DateOnly date) => Add("min_date_created", date);

    public BcOrdersSearch MinDateModified(DateOnly date) => Add("min_date_modified", date);

    public BcOrdersSearch MinId(int id) => Add("min_id", id);

    public BcOrdersSearch MinTotal(decimal total) => Add("min_total", total);

    public BcOrdersSearch PaymentMethod(string paymentMethod) => Add("payment_method", paymentMethod);

    public Task<BcDataResult<List<BcOrderResponseFull>>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(cancellationToken);

    public async Task<BcDataResult<List<T>>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrdersV2(),
            Filter,
            cancellationToken
        );

    public BcOrdersSearch Sort(BcOrderSort sort) => Add("sort", sort.ToValue());

    public BcOrdersSearch StatusId(int statusId) => Add("status_id", statusId);
}