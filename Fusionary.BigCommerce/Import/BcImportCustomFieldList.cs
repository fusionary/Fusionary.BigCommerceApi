namespace Fusionary.BigCommerce.Import;

public class BcImportCustomFieldList : List<BcImportCustomField>
{
    public BcImportCustomFieldList()
    { }

    public BcImportCustomFieldList(IEnumerable<BcImportCustomField> fields) : base(fields)
    { }

    public void Add(string key, string value, int? id = null) =>
        base.Add(new BcImportCustomField { Key = key, Value = value, Id = id });

    public static implicit operator string(BcImportCustomFieldList list) => list.ToString();

    public static BcImportCustomFieldList Parse(string? customFieldValue)
    {
        if (string.IsNullOrWhiteSpace(customFieldValue))
        {
            return new BcImportCustomFieldList();
        }

        var parts = customFieldValue.Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        return new BcImportCustomFieldList(parts.Select(BcImportCustomField.Parse));
    }

    public string ToFormattedString() => string.Join(
        ';',
        this.Select(x => x.ToFormattedString()).Where(x => !string.IsNullOrWhiteSpace(x))
    );

    public override string ToString() => ToFormattedString();
}