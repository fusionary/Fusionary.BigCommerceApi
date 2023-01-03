namespace Fusionary.BigCommerce.Types;

public record BcPagedResponse<TData>: BcResponse<List<TData>, BcMetadataPagination>
{
}