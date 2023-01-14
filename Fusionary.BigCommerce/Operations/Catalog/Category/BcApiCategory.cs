namespace Fusionary.BigCommerce.Operations;

public class BcApiCategory : IBcApiOperation
{
    private readonly IBcApi _api;

    public BcApiCategory(IBcApi api)
    {
        _api = api;
    }

    public BcApiCategoryCreate Create() => new(_api);

    public BcApiCategoryDelete Delete() => new(_api);

    /// <summary>
    /// Deletes Category objects. At least one filter parameter is required to perform the DELETE operation.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/d4e96c2f5d289-delete-categories
    /// </remarks>
    public BcApiCategoryDeleteBulk DeleteBulk() => new(_api);

    public BcApiCategoryGet Get() => new(_api);

    /// <summary>
    /// Search/Get all categories
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/9cc3a53863922-get-all-categories
    /// </remarks>
    public BcApiCategoryGetAll GetAll() => new(_api);

    public BcApiCategoryUpdate Update() => new(_api);
}