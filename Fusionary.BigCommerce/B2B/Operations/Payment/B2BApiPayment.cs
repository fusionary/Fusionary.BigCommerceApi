using Fusionary.BigCommerce.B2B.Types;

namespace Fusionary.BigCommerce.B2B.Operations;

public class B2BApiPayment(IBcApi api) : IBcApiOperation
{
    public B2BApiCompanyCreditStatusGet CreditStatusGet() => new(api);

    public B2BApiCompanyCreditStatusUpdate CreditStatusUpdate() => new(api);
}

public class B2BApiCompanyCreditStatusUpdate(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultDataWithMessage<B2BCompanyCreditStatus>> SendAsync(int companyId, B2BCompanyCreditStatus creditStatus, CancellationToken cancellationToken = default)
        => SendAsync<B2BCompanyCreditStatus>(companyId, creditStatus, cancellationToken);

    public Task<BcResultDataWithMessage<T>> SendAsync<T>(int companyId, B2BCompanyCreditStatus creditStatus, CancellationToken cancellationToken = default)
        => Api.PutDataWithMessageAsync<T>(B2BEndpoints.CreditStatus(companyId), creditStatus, Filter, Options, cancellationToken);
}

public class B2BApiCompanyCreditStatusGet(IBcApi api) : B2BRequestBuilder(api), IBcApiOperation
{
    public Task<BcResultDataWithMessage<B2BCompanyCreditStatus>> SendAsync(int companyId, CancellationToken cancellationToken = default)
        => SendAsync<B2BCompanyCreditStatus>(companyId, cancellationToken);

    public Task<BcResultDataWithMessage<T>> SendAsync<T>(int companyId, CancellationToken cancellationToken = default)
        => Api.GetDataWithMessageAsync<T>(B2BEndpoints.CreditStatus(companyId), Filter, Options, cancellationToken);
}