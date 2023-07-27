namespace Fusionary.BigCommerce.Import;

public class BcImportPipeDelimitedList : List<BcImportPipeDelimitedField>
{
    public BcImportPipeDelimitedList()
    { }

    public BcImportPipeDelimitedList(IEnumerable<BcImportPipeDelimitedField> fields) : base(fields)
    { }

    public void Add(string key, string value) =>
        base.Add(new BcImportPipeDelimitedField { Key = key, Value = value });

    public static implicit operator string(BcImportPipeDelimitedList list) => list.ToString();

    public static BcImportPipeDelimitedList Parse(string? customFieldValue)
    {
        if (string.IsNullOrWhiteSpace(customFieldValue))
        {
            return new BcImportPipeDelimitedList();
        }

        var parts = customFieldValue.Split('|', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        return new BcImportPipeDelimitedList(parts.Select(BcImportPipeDelimitedField.Parse));
    }

    public string ToFormattedString() => string.Join(
        '|',
        this.Select(x => x.ToFormattedString())
            .Where(x => !string.IsNullOrWhiteSpace(x))
    );

    public override string ToString() => ToFormattedString();
}
