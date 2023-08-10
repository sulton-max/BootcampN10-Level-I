#region Collection Aggregation Operations

// concat - 2 ta to'plamni birlashtirish
// intersect - 2 ta to'plamning bir xil elementlarini olish
// except - 2 ta to'plamning farqi
// union - 2 ta to'plamning birlashmasi - faqat unique elementlarni olish

// var listA = new List<int>
// {
//     1,
//     2,
//     3
// };
// var listB = new List<int>
// {
//     2,
//     4,
//     5
// };
// listA.Except(listB).ToList().ForEach(Console.WriteLine);

// Eski usul
// var aggregator = new CollectionAggregator();

// Yangi usul
var aggregator = null as ICollectionAggregator;
aggregator = new CollectionAggregator();

var listA = new List<int>
{
    1,
    2,
    3
};

var listB = new List<int>
{
    2,
    4,
    5
};

// aggregator = new NewCollectionAggregator();

Console.WriteLine("Concat result : ");
aggregator.Concat(listA, listB).ForEach(Console.WriteLine);

Console.WriteLine();
Console.WriteLine("Intersect result : ");
aggregator.Intersect(listA, listB).ForEach(Console.WriteLine);

public interface ICollectionAggregator
{
    List<T> Concat<T>(in List<T> listA, in List<T> listB);

    List<T> Intersect<T>(in List<T> listA, in List<T> listB);

    List<T> Except<T>(in List<T> listA, in List<T> listB);

    List<T> Union<T>(in List<T> listA, in List<T> listB);
}

public class CollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        list.AddRange(listA);
        list.AddRange(listB);

        return list;
    }

    public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
    {
        var list = new List<T>();
        foreach (var itemA in listA)
            if (listB.Contains(itemA))
                list.Add(itemA);

        return list;
    }

    public List<T> Except<T>(in List<T> listA, in List<T> listB)
    {
        throw new NotImplementedException();
    }

    public List<T> Union<T>(in List<T> listA, in List<T> listB)
    {
        throw new NotImplementedException();
    }
}

// Yangi usulni tushuntirish uchun
public class NewCollectionAggregator : ICollectionAggregator
{
    public List<T> Concat<T>(in List<T> listA, in List<T> listB)
    {
        throw new NotImplementedException();
    }

    public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
    {
        throw new NotImplementedException();
    }

    public List<T> Except<T>(in List<T> listA, in List<T> listB)
    {
        throw new NotImplementedException();
    }

    public List<T> Union<T>(in List<T> listA, in List<T> listB)
    {
        throw new NotImplementedException();
    }
}

#endregion