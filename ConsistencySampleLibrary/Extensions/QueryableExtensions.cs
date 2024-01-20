using System.Linq.Expressions;

namespace ConsistencySampleLibrary.Extensions;
public static class QueryableExtensions
{
    /// <summary>
    /// Allows to apply a null predicate in a Where condition without throwing an exception.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source">IQueryable list of entities.</param>
    /// <param name="predicate">Predicate (allows null).</param>
    /// <returns></returns>
    public static IQueryable<T> WhereNullSafe<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate)
    {
        return predicate is null ? source : source.Where(predicate);
    }
}
