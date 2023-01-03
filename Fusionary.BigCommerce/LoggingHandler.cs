using Microsoft.Extensions.Logging;

namespace Fusionary.BigCommerce;

public class LoggingHandler : DelegatingHandler
{
    private readonly ILogger<BigCommerceApi> _logger;

    public LoggingHandler(HttpMessageHandler innerHandler, ILogger<BigCommerceApi> logger) : base(innerHandler)
    {
        _logger = logger;
    }
    
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Content != null)
        {
            var requestContent = await request.Content.ReadAsStringAsync(cancellationToken);
            
            _logger.LogDebug("{Content}", requestContent);
        }
        
        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

        if (request.Content != null)
        {
            var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
            
            _logger.LogDebug("{Content}", responseContent);
        }

        return response;
    }
}