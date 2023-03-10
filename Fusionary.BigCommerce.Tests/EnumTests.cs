using System.Text.Json.Serialization;

using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce.Tests;

public class EnumTests
{
    public enum BcTestEnum
    {
        [JsonPropertyName("customer_id")]
        CustomerId,

        [JsonPropertyName("customer_id:desc")]
        CustomerIdDesc
    }

    [Fact]
    public void Can_Deserialize_Enum_Members()
    {
        var obj = BcJsonUtil.Deserialize<BcTestObject>("{\"type\":\"digital\",\"order_sort\":\"customer_id:desc\"}");
        Assert.NotNull(obj);
        if (obj is not null)
        {
            Assert.Equal(BcProductType.Digital, obj.Type);
            Assert.Equal(BcTestEnum.CustomerIdDesc, obj.OrderSort);
        }
    }

    [Fact]
    public void Can_Deserialize_Enum_Value()
    {
        var value = "customer_id:desc".FromValue<BcTestEnum>();
        Assert.Equal(BcTestEnum.CustomerIdDesc, value);
    }

    [Fact]
    public void Can_Serialize_Enum_Members()
    {
        var json = BcJsonUtil.Serialize(
            new BcTestObject { Type = BcProductType.Digital, OrderSort = BcTestEnum.CustomerIdDesc }
        );
        Assert.Equal("{\"type\":\"digital\",\"order_sort\":\"customer_id:desc\"}", json);
    }

    [Fact]
    public void Can_Serialize_Enum_Value()
    {
        var value = BcTestEnum.CustomerIdDesc.ToValue();
        Assert.Equal("customer_id:desc", value);
    }

    [Theory]
    [InlineData("ExampleOne", "example_one")]
    [InlineData("XML-test", "xml_test")]
    [InlineData("Example1", "example1")]
    public void Can_Snake_Case(string input, string expected)
    {
        var snaked = input.ToSnakeCase();
        Assert.Equal(expected, snaked);
    }

    public class BcTestObject
    {
        [JsonPropertyName("type")]
        public BcProductType Type { get; set; }

        [JsonPropertyName("order_sort")]
        public BcTestEnum OrderSort { get; set; }
    }
}