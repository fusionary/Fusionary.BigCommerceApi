namespace Fusionary.BigCommerce.Utils;

public class BcSnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string text) => text.ToSnakeCase();
}