using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

using Bogus;

using Fusionary.BigCommerce.Utils;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;
using Microsoft.Extensions.Hosting;

using NUnit.Framework;

using JsonSerializer = System.Text.Json.JsonSerializer;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Fusionary.BigCommerce.Tests;

public abstract class BcTestBase
{
    private CancellationTokenSource? _cts;
    private IServiceScope? _scope;

    /// <summary>
    /// An instance of <see cref="Faker" /> for generating random test data.
    /// </summary>
    protected static Faker Faker { get; } = new();

    /// <summary>
    /// The cancellation token source for the current test.
    /// </summary>
    /// <example>
    ///     <code>
    /// Cts.CancelAfter(TimeSpan.FromSeconds(10));
    ///
    /// var cancellationToken = Cts.Token;
    ///
    /// var result = await svc.CallSomeMethod(cancellationToken);
    /// </code>
    /// </example>
    protected CancellationTokenSource Cts => _cts ??= new CancellationTokenSource();

    protected DateTimeOffset Now => Services.GetService<TimeProvider>()?.GetUtcNow() ?? DateTimeOffset.UtcNow;

    protected IServiceProvider Services => _scope?.ServiceProvider!;

    /// <summary>
    /// Simulates the current API output serializer options.
    /// </summary>
    private static JsonSerializerOptions TestOutputSerializerOptions { get; } = new (BcJsonUtil.JsonOptions)
    {
        WriteIndented = true
    };

    private IHost TestHost { get; set; } = default!;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        TestHost = Host.CreateDefaultBuilder()
            .UseDefaultServiceProvider(x => x.ValidateScopes = false)
            .ConfigureAppConfiguration(
                (context, builder) =>
                {
                    builder.Add(
                        new MemoryConfigurationSource
                        {
                            InitialData = [new KeyValuePair<string, string?>("IS_LOCAL", "true")]
                        }
                    );

                    builder.AddUserSecrets(TestProject.Assembly);

                    BuildConfiguration(builder);
                }
            )
            .ConfigureServices(
                (context, services) =>
                {
                    var configuration = context.Configuration;

                    services
                        .AddLogging()
                        .AddContextMockingServices()
                        .AddBigCommerce(configuration);

                    ConfigureServices(services, configuration);
                }
            )
            .Build();

        await TestHost.StartAsync();
    }

    [OneTimeTearDown]
    public async Task OneTimeTearDownAsync()
    {
        await TestHost.StopAsync();

        TestHost.Dispose();
    }

    [SetUp]
    public void Setup()
    {
        _scope = TestHost.Services.CreateScope();
        _cts = new CancellationTokenSource();

        var httpContextAccessor = TestHost.Services.GetRequiredService<IHttpContextAccessor>();

        var httpContext = httpContextAccessor.HttpContext;

        if (httpContext is not null)
        {
            httpContext.RequestServices = _scope.ServiceProvider;
            httpContext.Items.Clear();
            httpContext.Request.Headers.Clear();
        }

        BeforeEach();
    }

    [TearDown]
    public void TearDown()
    {
        _scope?.Dispose();
        _cts?.Dispose();

        AfterEach();
    }

    protected static T ToObject<T>([StringSyntax("json")] string json)
    {
        return JsonSerializer.Deserialize<T>(json, TestOutputSerializerOptions)!;
    }

    /// <summary>
    /// Hook to run code after each test.
    /// </summary>
    protected virtual void AfterEach()
    { }

    /// <summary>
    /// Hook to run code before each test.
    /// </summary>
    protected virtual void BeforeEach()
    { }

    /// <summary>
    /// Extension point to modify the configuration builder.
    /// </summary>
    protected virtual IConfigurationBuilder BuildConfiguration(IConfigurationBuilder builder)
    {
        return builder;
    }

    /// <summary>
    /// Triggers immediate cancellation of the current test.
    /// </summary>
    protected void Cancel()
    {
        Cts.Cancel();
    }

    /// <summary>
    /// Triggers cancellation of the current test after the specified delay.
    /// </summary>
    protected void CancelAfter(TimeSpan delay)
    {
        Cts.CancelAfter(delay);
    }

    /// <summary>
    /// Called by <see cref="OneTimeSetupAsync" /> to configure services.
    /// </summary>
    /// <example>
    ///     <code>
    /// protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    /// {
    ///   services.AddScoped(_mockRepository.Object);
    ///   services.AddTransient&lt;IHelloWorldService, HelloWorldService&gt;();
    /// }
    /// </code>
    /// </example>
    protected virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    { }

    protected virtual void LogMessage(string message)
    {
        Console.WriteLine(message);
    }

    /// <summary>
    /// Prints a JSON serialized representation of the object to the console.
    /// </summary>
    protected virtual void DumpObject(object? value)
    {
        Console.WriteLine(value is null ? "<NULL>" : JsonSerializer.Serialize(value, TestOutputSerializerOptions));
    }

    protected virtual List<ValidationResult> ValidateModel(object model)
    {
        var validationResults = new List<ValidationResult>();

        var ctx = new ValidationContext(model, null, null);

        Validator.TryValidateObject(model, ctx, validationResults, true);

        return validationResults;
    }
}