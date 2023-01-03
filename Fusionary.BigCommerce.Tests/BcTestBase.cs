using Fusionary.UnitTesting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Xunit.Abstractions;

namespace Fusionary.BigCommerce.Tests;

public abstract class BcTestBase : TestBase
{
    protected BcTestBase(ITestOutputHelper outputHelper) : base(outputHelper)
    { }

    protected override IConfigurationBuilder BuildConfiguration(IConfigurationBuilder builder) =>
        builder.AddUserSecrets<BcTestBase>();

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddBigCommerce(configuration);
    }
}