using N33_T1.DataAccess.EntityContext;

namespace N33_T1.Extensions;

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

        // solution #1
        // var intersectedKeys = first.Select(keySelector).Intersect(second.Select(keySelector));
        // return (first.Where(item => intersectedKeys.Contains(keySelector(item))), second.Where(item => intersectedKeys.Contains(keySelector(item))));
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

        // solution #1
        // var intersectedKeys = first.Select(keySelector).Intersect(second.Select(keySelector));
        // return (first.Where(item => intersectedKeys.Contains(keySelector(item))), second.Where(item => intersectedKeys.Contains(keySelector(item))));
    }

    public static bool AnySafe<T>(this IEnumerable<T> @this) => @this?.Any() ?? false;
    //
    // public static ICollection<(TSource FirstItem, TSource SecondItem)> ZipIntersectUpdatedBy<TSource, TKey>(
    //     this ICollection<TSource> first,
    //     ICollection<TSource> second,
    //     Func<TSource, TKey> keySelector
    // )
    // {
    //     // solution #1
    //     // var intersectedKeys = first.Select(keySelector).Intersect(second.Select(keySelector));
    //     // var list = new List<(TSource, TSource)>();
    //     //
    //     // foreach (var key in intersectedKeys)
    //     // {
    //     //     var firstItem = first.First(item => keySelector(item).Equals(key));
    //     //     var secondItem = second.First(item => keySelector(item).Equals(key));
    //     //     list.Add((firstItem, secondItem));
    //     // }
    //     //
    //     // return list;
    //
    //     // solution #2
    //     var intersected = first.ZipIntersectBy(second, keySelector);
    //     return intersected.First.Zip(intersected.Second, (firstItem, secondItem) => (firstItem, secondItem)).ToList();
    // }

    public static ulong Update<TSource>(this ICollection<TSource> first, ICollection<TSource> second) where TSource : IUpdatableEntity<TSource>
    {
        var removed = first.ExceptBy(second.Select(item => item.Id), item => item.Id).ToList();
        var added = second.ExceptBy(first.Select(item => item.Id), item => item.Id).ToList();
        var updated = first.ZipIntersectBy(second, item => item.Id);

        removed.ForEach(item => first.Remove(item));
        added.ForEach(first.Add);

        return (ulong)(removed.Count() + added.Count() + updated.Count());

        // for(var index = 0; index < first.Count; index++)
        // {
        //     first
        //
        //
        //     var firstItem = first.ElementAt(index);
        //     var secondItem = second.FirstOrDefault(item => item.Id.Equals(firstItem.Id));
        //
        //     if (firstItem is not null && secondItem is not null && firstItem.GetHashCode() != secondItem.GetHashCode())
        //         firstItem.Update(secondItem);
        // }

        //
        // foreach (var item in removed)
        //     first.Remove(item);
        //
        // foreach (var item in added)
        //     first.Add(item);

        foreach (var (firstItem, secondItem) in updated)
            firstItem.Update(secondItem);
    }
}