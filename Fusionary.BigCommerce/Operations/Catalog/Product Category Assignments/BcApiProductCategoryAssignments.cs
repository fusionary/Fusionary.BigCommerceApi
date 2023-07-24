namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCategoryAssignments : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductCategoryAssignments(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductChannelAssignmentsCreate Create() => new(_api);

    public BcApiProductCategoryAssignmentsDelete Delete() => new(_api);

    public BcApiProductCategoryAssignmentsGetList Get() => new(_api);
}
