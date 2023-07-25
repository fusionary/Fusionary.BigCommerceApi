namespace Fusionary.BigCommerce.Import;

public record BcImportCustomField
{
    public int? Id { get; set; }

    public required string Name { get; set; }

    public required string Value { get; set; }

    public static BcImportCustomField Parse(string customFieldValue)
    {
        var parts = customFieldValue.Split('|', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        switch (parts.Length) {
            case > 2:
                throw new ArgumentException("Invalid custom field format", nameof(customFieldValue));
            case 0:
                return new BcImportCustomField { Name = string.Empty, Value = string.Empty };
        }

        var idPart   = parts.FirstOrDefault(IsIdPart);
        var namePart = parts.FirstOrDefault(partValue => !IsIdPart(partValue));

        if (idPart is not null)
        {
            var id = ParseIdPart(idPart);
            var (name, value) = ParseNamePartName(namePart);

            return new BcImportCustomField { Id = id, Name = name, Value = value };
        }
        else
        {
            var (name, value) = ParseNamePartName(namePart);
            return new BcImportCustomField { Name = name, Value = value };
        }
    }

    private static bool IsIdPart(string partValue) => partValue.StartsWith("id=", StringComparison.OrdinalIgnoreCase);

    private static int ParseIdPart(string idPart) => int.Parse(
        idPart.Split('=', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[1]
    );

    private static (string name, string value) ParseNamePartName(string? namePart)
    {
        if (string.IsNullOrWhiteSpace(namePart))
        {
            return (string.Empty, string.Empty);
        }

        var nameParts = namePart.Split('=', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        var name      = nameParts[0];
        var value     = nameParts[1];

        return (name, value);
    }

    public override string ToString()
    {
        var idPart   = Id.HasValue ? $"id={Id.Value}" : string.Empty;
        var namePart = !string.IsNullOrWhiteSpace(Name) ? $"{Name}={Value}" : string.Empty;
        return string.Join('|', new[] { idPart, namePart }.Where(x => !string.IsNullOrWhiteSpace(x)));
    }
}
