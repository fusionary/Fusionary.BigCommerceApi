using System.Reflection;

namespace Fusionary.BigCommerce.Tests;

public static class TestProject
{
    static TestProject()
    {
        var assembly = typeof(TestProject).Assembly;

        Assembly = assembly;
        AppName = assembly.GetName().Name!;
    }

    public static string AppName { get; }

    public static Assembly Assembly { get; }
}