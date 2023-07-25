namespace Fusionary.BigCommerce.Import;

public record BcImportCustomFieldCollection
{
    private List<BcImportCustomField>? _customFields;

    public List<BcImportCustomField> CustomFields
    {
        get => LazyInitializer.EnsureInitialized(ref _customFields);
        set => _customFields = value;
    }

    public static implicit operator string(BcImportCustomFieldCollection collection) => collection.ToString();

    public static BcImportCustomFieldCollection Parse(string? customFieldValue)
    {
        if (string.IsNullOrWhiteSpace(customFieldValue))
        {
            return new BcImportCustomFieldCollection();
        }

        var parts = customFieldValue.Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        return new BcImportCustomFieldCollection { CustomFields = parts.Select(BcImportCustomField.Parse).ToList() };
    }

    public override string ToString() => string.Join(
        ';',
        CustomFields.Select(x => x.ToString()).Where(x => !string.IsNullOrWhiteSpace(x))
    );
}
