using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fusionary.BigCommerce;

public static class ExtensionsForServiceCollection
{
    public static void AddBigCommerce(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<BigCommerceConfig>(configuration.GetSection("BigCommerce"));
        services.AddHttpClient<BigCommerceClient>()
            .ConfigurePrimaryHttpMessageHandler(
                () => new HttpClientHandler
                {
                    AllowAutoRedirect = false, UseCookies = false, AutomaticDecompression = DecompressionMethods.All
                }
            );
        services.AddTransient<IBcApi, BcApi>();
        services.AddTransient<IBcStorefrontGraphQL, BcStorefrontGraphQL>();

        if (!services.Contains(ServiceDescriptor.Singleton<IMemoryCache, MemoryCache>()))
        {
            services.AddMemoryCache();
        }

        services.AddSingleton<IBcTokenCache, BcTokenCache>();
    }
}