namespace Fusionary.BigCommerce;

public record BcDataResult<TData> : BcResult<TData, BcMetadataEmpty>
{
    public new bool HasMeta => false;
}