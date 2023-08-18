// Adding - mutation,

// Append -  elementni kolleksiyasini oxiriga qo'shish
// LINQ methodlari - asosiy kolleksiyani o'zgartirmaydi

using System.Text.Json;

var list = new List<int>
{
    10,
    91,
    11,
    67,
    2,
};

// list = list.Append(20).ToList();
//
//
// foreach (var item in list)
//     Console.WriteLine(item);
//

// var array = new[]
// {
//     10,
//     11,
//     67,
//     91
// };
//
// array = array.Append(20).ToArray();
//
// foreach (var item in array)
//     Console.WriteLine(item);

// var query = list.Where(number => number % 2 == 0).Order();
// foreach(var item in query)
//     Console.WriteLine(item);
//
// Console.WriteLine();

// list = list.Prepend(40).ToList();

// foreach (var item in list)
//     Console.WriteLine(item);

#region Aggregation

// Minimum
// Console.WriteLine(list.Min());


// Min - primitiv tipdagi kolleksiyalar uchun
// MinBy - complex tipdagi kolleksiyalar uchun

var accessory = new ProductType(500, "Accessory", "something");
var laptop = new ProductType(3000, "Laptop", "something");
var beverages = new ProductType(5, "Beverages", "something");

var products = new List<Product>()
{
    new("Razor", "X5", 100, accessory),
    new("Asus", "X6", 120, accessory),
    new("Asus", "X7", 120, accessory),
    new("Cola", "Fanta", 3, beverages)
};

// Maximum

// 23, 675, 232
// userA, userB, userC - By degan method ishlatiladi

// Console.WriteLine(products.MinBy(item => item.Price));
// Console.WriteLine(products.MaxBy(item => item.Price));
//
// // Average - By qo'shimchasi shartmas
// Console.WriteLine(products.Average(item => item.Price));
//
// // Sum
// Console.WriteLine(products.Sum(item => item.Price));

// Aggregate
// var result = list.Aggregate((first, second) =>
// {
//     Console.WriteLine($"First: {first}, Second: {second}");
//     return first - second;
// });

#endregion

#region

// DefaultIfEmpty - bo'sh bo'lsagina berilgan qiymatni qo'shadi
var newMiniMarket = new List<int>();
var result = newMiniMarket.DefaultIfEmpty(10);

// Select
var prices = products.Select(item => item.Price).Average();
var brandes = products.Select(item => item.Brand).Distinct();

// Anonymous object
var productsSimple = products.Select(item => new
    {
        Name = item.Model,
        item.Price
    })
    .ToList();

// Select Many
// accessory.Products.Add(new ("", "", 30, accessory));
// accessory.Products.Add(new ("", "", 45, accessory));
// accessory.Products.Add(new ("", "", 67, accessory));
//
// laptop.Products.Add(new("", "", 5000, laptop));

var productsTypes = new List<ProductType>()
{
    accessory,
    laptop,
    beverages
};


// foreach (var productType in productsTypes)
// {
//     foreach (var product in productType.Products)
//     {
//         product
//         productsType
//     }
// }

// var resultMany = productsTypes.SelectMany(productType => productType.Products,
//     (productType, product) =>
//     {
//         return new
//         {
//             product.Price,
//             productType.RecommendedPrice
//         };
//     });
//
// Console.WriteLine(JsonSerializer.Serialize(resultMany));

// Cast

// OfType

var mixedProducts = new List<IProduct>();
mixedProducts.Add(new Laptop());
mixedProducts.Add(new Laptop());
mixedProducts.Add(new Phone());
mixedProducts.Add(new Laptop());

// Cast - 1 tipdan boshqa tipga o'tkazish va exception bo'lishi mumkin
// var laptops = mixedProducts.Cast<Laptop>().ToList();

var laptops = mixedProducts.OfType<Laptop>().ToList();

// Distinct - duplicatelardan bittasini tanlash
// Distinct - primtiv
// DictinctBy - complex

// Group - guruhlash

// Group - primitv
// GroupBy - complex

// var groupedList = products.GroupBy(item => item.Brand)
//     .Select(item => new
//     {
//         item.Key,
//         Items = item.ToList()
//     })
//     .ToList();

var groupJoined = productsTypes.GroupJoin(products,
        productType => productType,
        product => product.Type,
        (currentType, currentProduct) => new
        {
            productType = currentType,
            products = currentProduct
        })
    .ToList();

Console.WriteLine(JsonSerializer.Serialize(groupJoined));

#endregion

// Relation - is-a realtion and has-a relation
//

public class ProductType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    // public List<Product> Products { get; set; } = new();
    public int RecommendedPrice { get; set; }

    public ProductType(int recommendedPrice, string name, string description)
    {
        Id = Guid.NewGuid();
        RecommendedPrice = recommendedPrice;
        Name = name;
        Description = description;
    }
}

// IPhone is a phone
// IPhone has phone

// Relation - has-a realtion
public interface IProduct
{

}

public class Laptop : IProduct
{

}

public class Phone : IProduct
{

}

public class Product : IProduct
{
    public Guid Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public ProductType Type { get; set; }
    public int Price { get; set; }

    public Product(string brand, string model, int price, ProductType type)
    {
        Id = Guid.NewGuid();
        Brand = brand;
        Model = model;
        Price = price;
        Type = type;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Price: {Price}";
    }
}