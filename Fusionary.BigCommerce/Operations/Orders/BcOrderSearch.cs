namespace Fusionary.BigCommerce.Operations;

public class BcOrderSearch : BcRequestBuilder, IBcPageableFilter
{
    public BcOrderSearch(IBcApi api) : base(api)
    { }

    public Task<BcResultData<List<BcOrderResponseFull>>> SendAsync(CancellationToken cancellationToken) =>
        SendAsync<BcOrderResponseFull>(cancellationToken);

    public async Task<BcResultData<List<T>>> SendAsync<T>(CancellationToken cancellationToken) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrdersV2(),
            Filter,
            Options,
            cancellationToken
        );

    #region Filters

    public BcOrderSearch CartId(object cartId) => this.Add("cart_id", cartId);

    public BcOrderSearch ChannelId(object channelId) => this.Add("channel_id", channelId);

    public BcOrderSearch CustomerId(object customerId) => this.Add("customer_id", customerId);

    public BcOrderSearch Email(string email) => this.Add("email", email);

    public BcOrderSearch IsDeleted(bool isDeleted) => this.Add("is_deleted", isDeleted);

    public BcOrderSearch MaxDateCreated(BcDateTime date) => this.Add("max_date_created", date);

    public BcOrderSearch MaxDateModified(BcDateTime date) => this.Add("max_date_modified", date);

    public BcOrderSearch MaxId(int id) => this.Add("max_id", id);

    public BcOrderSearch MaxTotal(decimal total) => this.Add("max_total", total);

    public BcOrderSearch MinDateCreated(BcDateTime date) => this.Add("min_date_created", date);

    public BcOrderSearch MinDateModified(BcDateTime date) => this.Add("min_date_modified", date);

    public BcOrderSearch MinId(int id) => this.Add("min_id", id);

    public BcOrderSearch MinTotal(decimal total) => this.Add("min_total", total);

    public BcOrderSearch PaymentMethod(string paymentMethod) => this.Add("payment_method", paymentMethod);

    public BcOrderSearch Sort(BcOrderSort sort) => this.Add("sort", sort.ToValue());

    public BcOrderSearch StatusId(int statusId) => this.Add("status_id", statusId);

    #endregion
}