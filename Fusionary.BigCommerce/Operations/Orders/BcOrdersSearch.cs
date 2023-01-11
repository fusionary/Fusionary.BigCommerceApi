namespace Fusionary.BigCommerce.Operations;

public class BcOrdersSearch : BcRequestBuilder, IBcPageableFilter
{
    public BcOrdersSearch(IBcApi api) : base(api)
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

    public BcOrdersSearch CartId(object cartId) => this.Add("cart_id", cartId);

    public BcOrdersSearch ChannelId(object channelId) => this.Add("channel_id", channelId);

    public BcOrdersSearch CustomerId(object customerId) => this.Add("customer_id", customerId);

    public BcOrdersSearch Email(string email) => this.Add("email", email);

    public BcOrdersSearch IsDeleted(bool isDeleted) => this.Add("is_deleted", isDeleted);

    public BcOrdersSearch MaxDateCreated(BcDateTime date) => this.Add("max_date_created", date);

    public BcOrdersSearch MaxDateModified(BcDateTime date) => this.Add("max_date_modified", date);

    public BcOrdersSearch MaxId(int id) => this.Add("max_id", id);

    public BcOrdersSearch MaxTotal(decimal total) => this.Add("max_total", total);

    public BcOrdersSearch MinDateCreated(BcDateTime date) => this.Add("min_date_created", date);

    public BcOrdersSearch MinDateModified(BcDateTime date) => this.Add("min_date_modified", date);

    public BcOrdersSearch MinId(int id) => this.Add("min_id", id);

    public BcOrdersSearch MinTotal(decimal total) => this.Add("min_total", total);

    public BcOrdersSearch PaymentMethod(string paymentMethod) => this.Add("payment_method", paymentMethod);

    public BcOrdersSearch Sort(BcOrderSort sort) => this.Add("sort", sort.ToValue());

    public BcOrdersSearch StatusId(int statusId) => this.Add("status_id", statusId);

    #endregion
}