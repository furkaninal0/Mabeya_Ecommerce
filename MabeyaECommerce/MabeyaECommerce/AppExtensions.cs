using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace MabeyaECommerce;

public static class AppExtensions
{
    public static string ToSafeUrlString(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return "";

        var cleaned = string.Concat(text.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)));

        var result = Regex.Replace(cleaned.Trim(), @"\s+", "-").ToLower();

        return result;
    }


}
