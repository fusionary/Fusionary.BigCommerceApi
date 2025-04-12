namespace Fusionary.BigCommerce.Operations;

public class BcApiOrdersSearch(IBcApi api) : BcRequestBuilder(api), IBcApiOperation, IBcPageableFilter
{
    public Task<BcResultData<List<BcOrderResponseFull>>> SendAsync(CancellationToken cancellationToken = default) =>
        SendAsync<BcOrderResponseFull>(cancellationToken);

    public async Task<BcResultData<List<T>>> SendAsync<T>(CancellationToken cancellationToken = default) =>
        await Api.GetDataAsync<List<T>>(
            BcEndpoint.OrdersV2(),
            Filter,
            Options,
            cancellationToken
        );

    #region Filters

    public BcApiOrdersSearch CartId(object cartId) => this.Add("cart_id", cartId);

    public BcApiOrdersSearch ChannelId(object channelId) => this.Add("channel_id", channelId);

    public BcApiOrdersSearch CustomerId(object customerId) => this.Add("customer_id", customerId);

    public BcApiOrdersSearch Email(string email) => this.Add("email", email);

    public BcApiOrdersSearch IsDeleted(bool isDeleted) => this.Add("is_deleted", isDeleted);

    public BcApiOrdersSearch MaxDateCreated(BcDateTime date) => this.Add("max_date_created", date);

    public BcApiOrdersSearch MaxDateModified(BcDateTime date) => this.Add("max_date_modified", date);

    public BcApiOrdersSearch MaxId(int id) => this.Add("max_id", id);

    public BcApiOrdersSearch MaxTotal(decimal total) => this.Add("max_total", total);

    public BcApiOrdersSearch MinDateCreated(BcDateTime date) => this.Add("min_date_created", date);

    public BcApiOrdersSearch MinDateModified(BcDateTime date) => this.Add("min_date_modified", date);

    public BcApiOrdersSearch MinId(int id) => this.Add("min_id", id);

    public BcApiOrdersSearch MinTotal(decimal total) => this.Add("min_total", total);

    public BcApiOrdersSearch PaymentMethod(string paymentMethod) => this.Add("payment_method", paymentMethod);

    public BcApiOrdersSearch Sort(BcOrderSort sort) => this.Add("sort", sort.ToValue());

    public BcApiOrdersSearch StatusId(int statusId) => this.Add("status_id", statusId);

    #endregion
}