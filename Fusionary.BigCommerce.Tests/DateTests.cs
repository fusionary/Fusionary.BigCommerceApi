using System.Globalization;

namespace Fusionary.BigCommerce.Tests;

public class DateTests : BcTestBase
{
    [Test]
    public void Can_Parse_Rfc2822_Date()
    {
        var dt = DateTimeOffset.Parse("Wed, 10 Jan 2018 21:05:30 +0000", CultureInfo.CurrentCulture);

        dt.Year.Should().Be(2018);
        dt.Month.Should().Be(1);
        dt.Day.Should().Be(10);
        dt.Hour.Should().Be(21);
        dt.Minute.Should().Be(5);
        dt.Second.Should().Be(30);
        dt.Offset.Hours.Should().Be(0);
    }

    [Test]
    public void Can_Write_Rfc2822_Date()
    {
        const string input = "Wed, 10 Jan 2018 21:05:30 +0000";

        var dt = DateTimeOffset.Parse(input, CultureInfo.CurrentCulture);

        input.Should().BeEquivalentTo(dt.ToString("ddd, dd MMM yyyy HH:mm:ss zzzz").Remove(29, 1));
    }
}