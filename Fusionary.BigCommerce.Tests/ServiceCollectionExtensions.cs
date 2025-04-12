using Microsoft.AspNetCore.Http;

namespace Fusionary.BigCommerce.Tests;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddContextMockingServices(this IServiceCollection services)
    {
        services.AddSingleton(CreateHttpContextAccessor);

        return services;
    }

    private static IHttpContextAccessor CreateHttpContextAccessor(IServiceProvider serviceProvider)
    {
        Mock<IHttpContextAccessor> httpContextMock = new();
        DefaultHttpContext         httpContext     = new() { RequestServices = serviceProvider };

        httpContextMock.Setup(_ => _.HttpContext).Returns(httpContext);

        return httpContextMock.Object;
    }
}