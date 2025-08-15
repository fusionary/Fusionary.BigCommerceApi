namespace Fusionary.BigCommerce.Operations.Order_Transactions;

public class BcApiOrderTransactions(IBcApi api) : IBcApiOperation
{
    public BcApiOrderTransactionsGet Get() => new(api);
}