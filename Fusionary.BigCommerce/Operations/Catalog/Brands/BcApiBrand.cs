using Fusionary.BigCommerce.Operations.BatchMetafields;

namespace Fusionary.BigCommerce.Operations;

public class BcApiBrand(IBcApi api) : IBcApiOperation
{
    public BcApiBrandsCreate Create() => new(api);

    public BcApiBrandsDelete Delete() => new(api);

    public BcApiBrandsDeleteBulk DeleteBulk() => new(api);

    public BcApiBrandsGet Get() => new(api);

    /// <summary>
    /// Search/Get all brands
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/api-reference/c2610608c20c8-get-all-brands
    /// </remarks>
    public BcApiBrandsGetAll GetAll() => new(api);

    public BcApiBrandImage Image() => new(api);

    public BcApiBrandMetafields Metafields() => new(api);
    
    public BcApiBrandBatchMetafields BatchMetafields() => new(api);

    public BcApiBrandsUpdate Update() => new(api);
}