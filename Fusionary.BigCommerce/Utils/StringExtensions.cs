using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Fusionary.BigCommerce.Utils;

public static class StringExtensions
{
    /// <summary>
    /// Converts the value to <typeparamref name="TValue" />
    /// </summary>
    /// <typeparam name="TValue">The type of the t value.</typeparam>
    /// <param name="value">The value.</param>
    /// <returns>The converted value or default</returns>
    public static TValue? As<TValue>(this string? value) => As<TValue?>(value, default);

    /// <summary>
    /// Converts the value to <typeparamref name="TValue" />
    /// </summary>
    /// <typeparam name="TValue">The type of the t value.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The converted value or default</returns>
    [SuppressMessage(
        "Microsoft.Design",
        "CA1031:DoNotCatchGeneralExceptionTypes",
        Justification = "We want to make this user friendly and return the default value on all failures"
    )]
    public static TValue As<TValue>(this string? value, TValue defaultValue)
    {
        try
        {
            var converter = TypeDescriptor.GetConverter(typeof(TValue));

            if (converter.CanConvertFrom(typeof(string)) && value != null)
            {
                return (TValue?)converter.ConvertFrom(value) ?? defaultValue;
            }

            // try the other direction
            converter = TypeDescriptor.GetConverter(typeof(string));

            if (converter.CanConvertTo(typeof(TValue)))
            {
                return (TValue?)converter.ConvertTo(value ?? "", typeof(TValue)) ?? defaultValue;
            }
        }
        catch
        {
            // eat all exceptions and return the defaultValue, assumption is that its always a parse/format exception
        }

        return defaultValue;
    }
}