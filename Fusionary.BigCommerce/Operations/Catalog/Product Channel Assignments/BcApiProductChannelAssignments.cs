namespace Fusionary.BigCommerce.Operations;

public class BcApiProductChannelAssignments : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductChannelAssignments(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductChannelAssignmentsCreate Create() => new(_api);

    public BcApiProductChannelAssignmentsDelete Delete() => new(_api);

    public BcApiProductChannelAssignmentsGetList Get() => new(_api);
}
