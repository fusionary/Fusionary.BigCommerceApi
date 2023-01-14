namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFields : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiProductCustomFields(IBcApi api)
    {
        _api = api;
    }

    public BcApiProductCustomsFieldCreate Create() => new(_api);

    public BcApiProductCustomFieldsDelete Delete() => new(_api);

    public BcApiProductCustomFieldsGet Get() => new(_api);

    public BcApiProductCustomFieldsGetList GetAll() => new(_api);

    public BcApiProductCustomFieldsUpdate Update() => new(_api);
}