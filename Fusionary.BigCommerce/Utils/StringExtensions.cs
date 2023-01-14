using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

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

    [SuppressMessage("ReSharper", "CognitiveComplexity")]
    public static string ToSnakeCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        var builder          = new StringBuilder(text.Length + Math.Min(2, text.Length / 5));
        var previousCategory = default(UnicodeCategory?);

        for (var currentIndex = 0; currentIndex < text.Length; currentIndex++)
        {
            var currentChar = text[currentIndex];
            if (currentChar == '_')
            {
                builder.Append('_');
                previousCategory = null;
                continue;
            }

            var currentCategory = char.GetUnicodeCategory(currentChar);
            switch (currentCategory)
            {
                case UnicodeCategory.UppercaseLetter:
                case UnicodeCategory.TitlecaseLetter:
                    if (previousCategory == UnicodeCategory.SpaceSeparator ||
                        previousCategory == UnicodeCategory.LowercaseLetter ||
                        (previousCategory != UnicodeCategory.DecimalDigitNumber &&
                         previousCategory != null &&
                         currentIndex > 0 &&
                         currentIndex + 1 < text.Length &&
                         char.IsLower(text[currentIndex + 1])))
                    {
                        builder.Append('_');
                    }

                    currentChar = char.ToLower(currentChar, CultureInfo.InvariantCulture);
                    break;

                case UnicodeCategory.LowercaseLetter:
                case UnicodeCategory.DecimalDigitNumber:
                    if (previousCategory == UnicodeCategory.SpaceSeparator)
                    {
                        builder.Append('_');
                    }

                    break;

                default:
                    if (previousCategory != null)
                    {
                        previousCategory = UnicodeCategory.SpaceSeparator;
                    }

                    continue;
            }

            builder.Append(currentChar);
            previousCategory = currentCategory;
        }

        return builder.ToString();
    }
}