using System.Reflection;

namespace Rubius.SharedKernel.Application.Linq;

public static class LinqExtensions
{
    /// <summary>
    /// Группировать по свойствам
    /// </summary>
    public static IEnumerable<KeyValuePair<PropertyInfo, IEnumerable<object?>>> GroupByProperties<T>(this IEnumerable<T> items)
    {
        return typeof(T).GetProperties().Select(prop =>
            KeyValuePair.Create(prop, items.GroupBy(item =>
                prop.GetValue(item)).Select(g => g.Key)));
    }
}