namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCategoryAssignments(IBcApi api) : IBcApiOperation
{
    public BcApiProductCategoryAssignmentsCreate Create() => new(api);

    public BcApiProductCategoryAssignmentsDelete Delete() => new(api);

    public BcApiProductCategoryAssignmentsGetList Get() => new(api);
}