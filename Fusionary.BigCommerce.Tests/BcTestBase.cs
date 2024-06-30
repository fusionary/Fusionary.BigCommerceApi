using Bogus;

using Fusionary.BigCommerce.Utils;
using Fusionary.UnitTesting;

using Microsoft.Extensions.Configuration; 
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fusionary.BigCommerce.Tests;


public abstract class BcTestBase : TestBase
{
    protected BcTestBase(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    protected Faker Faker { get; } = new();

    protected override IConfigurationBuilder BuildConfiguration(IConfigurationBuilder builder) =>
    builder.AddUserSecrets<BcTestBase>();

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration) =>
        services.AddBigCommerce(configuration);

    protected new void DumpObject(object? value) => Logger.WriteLine(BcJsonUtil.Serialize(value, true));
}