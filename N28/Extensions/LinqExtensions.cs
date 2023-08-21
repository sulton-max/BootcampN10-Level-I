using N28.Models.Common;

namespace N28.Extensions;

public static class LinqExtensions
{
    public static IEnumerable<(TSource firstItem, TSource secondItem)> ZipIntersectBy<TSource, TKey>(
        this ICollection<TSource> first,
        ICollection<TSource> second,
        Func<TSource, TKey> keySelector
    )
    {
        if (!first.AnySafe())
            throw new ArgumentNullException(nameof(first));
        if (!second.AnySafe())
            throw new ArgumentNullException(nameof(second));
        if (keySelector is null)
            throw new ArgumentNullException(nameof(keySelector));

        return ZipIntersectByIterator(first, second, keySelector);
    }


    private static IEnumerable<(TSource firstItem, TSource secondItem)> ZipIntersectByIterator<TSource, TKey>(
        this ICollection<TSource> first,
        ICollection<TSource> second,
        Func<TSource, TKey> keySelector
    )
    {
        foreach (var firstItem in first)
        {
            var key = keySelector(firstItem);
            var secondItem = second.FirstOrDefault(secondItem => keySelector(secondItem).Equals(key));

            if (firstItem is not null && secondItem is not null && firstItem.GetHashCode() != secondItem.GetHashCode())
                yield return (firstItem, secondItem);
        }
    }

    public static bool AnySafe<T>(this IEnumerable<T> @this) => @this?.Any() ?? false;

    public static void Update<TSource>(this ICollection<TSource> first, ICollection<TSource> second) where TSource : class, IEntity, IUpdatableEntity<TSource>
    {
        var removed = first.ExceptBy(second.Select(item => item.Id), item => item.Id).ToList();
        var added = second.ExceptBy(first.Select(item => item.Id), item => item.Id).ToList();
        var updated = first.ZipIntersectBy(second, item => item.Id);

        removed.ForEach(item => first.Remove(item));
        added.ForEach(first.Add);

        foreach (var (firstItem, secondItem) in updated)
            firstItem.Update(secondItem);
    }
}