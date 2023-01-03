namespace Fusionary.BigCommerce.Types;

public record BcDataResponse<TData> : BcResponse<TData, BcMetadataEmpty, BcMetaError>
{ }