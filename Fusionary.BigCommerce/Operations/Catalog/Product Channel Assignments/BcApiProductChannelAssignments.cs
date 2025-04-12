namespace Fusionary.BigCommerce.Operations;

public class BcApiProductChannelAssignments(IBcApi api) : IBcApiOperation
{
    public BcApiProductChannelAssignmentsCreate Create() => new(api);

    public BcApiProductChannelAssignmentsDelete Delete() => new(api);

    public BcApiProductChannelAssignmentsGetList Get() => new(api);
}