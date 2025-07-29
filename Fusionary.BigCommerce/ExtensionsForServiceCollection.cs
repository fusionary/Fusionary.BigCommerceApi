using System.Diagnostics.CodeAnalysis;
using System.Reflection;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Polly;
using Polly.Retry;

namespace Fusionary.BigCommerce;

public static class ExtensionsForServiceCollection
{
    /// <summary>
    /// Sets up the BigCommerce client and related services.
    /// </summary>
    /// <remarks>
    /// See https://developer.bigcommerce.com/docs/start/best-practices/api-rate-limits#best-practices for Rate Limits
    /// information.
    /// </remarks>
    public static IServiceCollection AddBigCommerce(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<BigCommerceConfig>(configuration.GetSection("BigCommerce"));
        services.AddHttpClient<BigCommerceClient>()
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                {
                    AllowAutoRedirect = false, UseCookies = false, AutomaticDecompression = DecompressionMethods.All
                }
            )
            .AddPolicyHandler((serviceProvider, _) => BcRetryPolicy.CreateBigCommerceRetryPolicy(serviceProvider));


        services.AddTransient<IBcApi, BcApi>();
        services.AddTransient<IBcStorefrontGraphQL, BcStorefrontGraphQL>();

        if (!services.Contains(ServiceDescriptor.Singleton<IMemoryCache, MemoryCache>()))
        {
            services.AddMemoryCache();
        }

        services.AddSingleton<IBcTokenCache, BcTokenCache>();
        services.RegisterAllApiOperations(typeof(IBcApiOperation).Assembly);

        return services;
    }



    public static void RegisterAllApiOperations(this IServiceCollection services, Assembly assembly)
    {
        var baseType = typeof(IBcApiOperation);

        var typesFromAssemblies =
            assembly.DefinedTypes.Where(x => !x.IsAbstract && x.GetInterfaces().Contains(baseType));

        foreach (var type in typesFromAssemblies)
        {
            services.Add(new ServiceDescriptor(type, type, ServiceLifetime.Transient));
        }
    }

    public static void RegisterAllTypes<T>(
        this IServiceCollection services,
        ServiceLifetime lifetime = ServiceLifetime.Transient
    ) =>
        RegisterAllTypes<T>(services, [typeof(T).Assembly], lifetime);

    [SuppressMessage(
        "Major Code Smell",
        "S3928:Parameter names used into ArgumentException constructors should match an existing one "
    )]
    public static void RegisterAllTypes<T>(
        this IServiceCollection services,
        IEnumerable<Assembly> assemblies,
        ServiceLifetime lifetime = ServiceLifetime.Transient
    )
    {
        var baseType = typeof(T);

        if (!baseType.IsInterface)
        {
            throw new ArgumentOutOfRangeException(nameof(T), $"{nameof(T)} must be an interface");
        }

        var typesFromAssemblies = assemblies.SelectMany(a =>
            a.DefinedTypes.Where(x => !x.IsAbstract && x.GetInterfaces().Contains(baseType))
        );

        foreach (var type in typesFromAssemblies)
        {
            var serviceType = type.GetInterfaces().FirstOrDefault(interfaceType => interfaceType != baseType) ?? type;

            services.Add(new ServiceDescriptor(serviceType, type, lifetime));
        }
    }
}