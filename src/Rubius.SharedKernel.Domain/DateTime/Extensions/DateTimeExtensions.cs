using Rubius.SharedKernel.Domain.DateTime.Constants;

namespace Rubius.SharedKernel.Domain.DateTime.Extensions;

public static class DateTimeExtensions
{
    public static string ToDefaultFormat(this System.DateTime dateTime)
    {
        return dateTime.ToString(DateTimeConstants.DefaultFormat);
    }

    public static string ToDefaultFormat(this DateOnly dateOnly)
    {
        return dateOnly.ToString(DateOnlyConstants.DefaultFormat);
    }

    public static string ToDefaultFormat(this TimeOnly timeOnly)
    {
        return timeOnly.ToString(TimeOnlyConstants.DefaultFormat);
    }

    public static string ToFileNameFormat(this System.DateTime dateTime)
    {
        return dateTime.ToString(DateTimeConstants.FileNameFormat);
    }
    
    public static string ToFileNameFormat(this DateOnly dateOnly)
    {
        return dateOnly.ToString(DateOnlyConstants.FileNameFormat);
    }

    public static string ToFileNameFormat(this TimeOnly timeOnly)
    {
        return timeOnly.ToString(TimeOnlyConstants.FileNameFormat);
    }
}