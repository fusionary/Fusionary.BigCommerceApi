using Fusionary.BigCommerce.Operations.BatchMetafields;

namespace Fusionary.BigCommerce.Operations;

public class BcApiCategory(IBcApi api) : IBcApiOperation
{
    public BcApiCategoryBatchMetafields BatchMetafields() => new(api); 
    
    public BcApiCategoryCreate Create() => new(api);

    public BcApiCategoryDelete Delete() => new(api);

    /// <summary>
    /// Deletes Category objects. At least one filter parameter is required to perform the DELETE operation.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/d4e96c2f5d289-delete-categories
    /// </remarks>
    public BcApiCategoryDeleteBulk DeleteBulk() => new(api);

    public BcApiCategoryGet Get() => new(api);

    /// <summary>
    /// Search/Get all categories
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/9cc3a53863922-get-all-categories
    /// </remarks>
    public BcApiCategoryGetAll GetAll() => new(api);

    public BcApiCategoryImage Image() => new(api);

    public BcApiCategoryMetafields Metafields() => new(api);

    public BcApiCategoryUpdate Update() => new(api);
}