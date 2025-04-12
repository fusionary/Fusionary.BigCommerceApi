namespace Fusionary.BigCommerce.Operations;

public class BcApiProductCustomFields(IBcApi api) : IBcApiOperation
{
    public BcApiProductCustomsFieldCreate Create() => new(api);

    public BcApiProductCustomFieldsDelete Delete() => new(api);

    public BcApiProductCustomFieldsGet Get() => new(api);

    public BcApiProductCustomFieldsGetList GetAll() => new(api);

    public BcApiProductCustomFieldsUpdate Update() => new(api);
}