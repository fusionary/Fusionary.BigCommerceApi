namespace Fusionary.BigCommerce.Tests;

public class DateTests : BcTestBase

{
    public DateTests(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    [Fact]
    public void Can_Parse_Rfc2822_Date()
    {
        var dt = DateTimeOffset.Parse("Wed, 10 Jan 2018 21:05:30 +0000");

        Assert.Equal(2018, dt.Year);
        Assert.Equal(1, dt.Month);
        Assert.Equal(10, dt.Day);
        Assert.Equal(21, dt.Hour);
        Assert.Equal(5, dt.Minute);
        Assert.Equal(30, dt.Second);
        Assert.Equal(0, dt.Offset.Hours);
    }

    [Fact]
    public void Can_Write_Rfc2822_Date()
    {
        const string input = "Wed, 10 Jan 2018 21:05:30 +0000";

        var dt = DateTimeOffset.Parse(input);

        Assert.Equal(input, dt.ToString("ddd, dd MMM yyyy HH:mm:ss zzzz").Remove(29, 1));
    }
}