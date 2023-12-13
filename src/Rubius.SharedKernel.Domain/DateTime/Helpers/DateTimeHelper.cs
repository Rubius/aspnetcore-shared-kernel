using System.Globalization;

namespace Rubius.SharedKernel.Domain.DateTime.Helpers;

public static class DateTimeHelper
{
    public static System.DateTime? ParseOrNull(string? dateTime)
    {
        return System.DateTime.TryParse(dateTime, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result)
            ? result
            : null;
    }
}