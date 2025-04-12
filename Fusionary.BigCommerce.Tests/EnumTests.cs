using System.Text.Json.Serialization;

using Fusionary.BigCommerce.Utils;

namespace Fusionary.BigCommerce.Tests;

public class EnumTests
{
    [SuppressMessage("Minor Code Smell", "S2344:Enumeration type names should not have \"Flags\" or \"Enum\" suffixes")]
    public enum BcTestEnum
    {
        [JsonPropertyName("customer_id")]
        CustomerId,

        [JsonPropertyName("customer_id:desc")]
        CustomerIdDesc
    }

    [Test]
    public void Can_Deserialize_Enum_Members()
    {
        var obj = BcJsonUtil.Deserialize<BcTestObject>("{\"type\":\"digital\",\"order_sort\":\"customer_id:desc\"}");

        obj.Should().NotBeNull();

        if (obj is not null)
        {
            obj.Type.Should().Be(BcProductType.Digital);
            obj.OrderSort.Should().Be(BcTestEnum.CustomerIdDesc);
        }
    }

    [Test]
    public void Can_Deserialize_Enum_Value()
    {
        var value = "customer_id:desc".FromValue<BcTestEnum>();

        value.Should().Be(BcTestEnum.CustomerIdDesc);
    }

    [Test]
    public void Can_Serialize_Enum_Members()
    {
        var json = BcJsonUtil.Serialize(
            new BcTestObject { Type = BcProductType.Digital, OrderSort = BcTestEnum.CustomerIdDesc }
        );

        json.Should().Be("{\"type\":\"digital\",\"order_sort\":\"customer_id:desc\"}");
    }

    [Test]
    public void Can_Serialize_Enum_Value()
    {
        var value = BcTestEnum.CustomerIdDesc.ToValue();
        value.Should().Be("customer_id:desc");
    }

    [TestCase("ExampleOne", "example_one")]
    [TestCase("XML-test", "xml_test")]
    [TestCase("Example1", "example1")]
    public void Can_Snake_Case(string input, string expected)
    {
        var snaked = input.ToSnakeCase();
        snaked.Should().Be(expected);
    }

    public class BcTestObject
    {
        [JsonPropertyName("type")]
        public BcProductType Type { get; set; }

        [JsonPropertyName("order_sort")]
        public BcTestEnum OrderSort { get; set; }
    }
}