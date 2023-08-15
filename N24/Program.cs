var laptops = new List<Laptop>
{
    new Laptop("Dell", "Inspiron 15", 799, 15),
    new Laptop("HP", "Pavilion 14", 699, 14),
    new Laptop("Lenovo", "IdeaPad 5", 849, 15),
    new Laptop("Acer", "Aspire 5", 599, 15),
    new Laptop("Apple", "MacBook Air", 999, 13),
    new Laptop("Asus", "ZenBook 14", 899, 14),
    new Laptop("Microsoft", "Surface Laptop 4", 1199, 13),
    new Laptop("HP", "Envy x360", 799, 13),
    new Laptop("Dell", "XPS 13", 1299, 13),
    new Laptop("Lenovo", "ThinkPad X1 Carbon", 1499, 14),
    new Laptop("Asus", "ROG Zephyrus G14", 1499, 14),
    new Laptop("Acer", "Predator Helios 300", 1099, 15),
    new Laptop("HP", "Spectre x360", 1299, 15),
    new Laptop("Dell", "Alienware m15", 1999, 15),
    new Laptop("Lenovo", "Legion 5", 999, 15),
    new Laptop("MSI", "GS66 Stealth", 1799, 15),
    new Laptop("Apple", "MacBook Pro", 1299, 13),
    new Laptop("Asus", "VivoBook S15", 699, 15),
    new Laptop("HP", "Omen 15", 1199, 15),
    new Laptop("Dell", "Latitude 14", 899, 14)
};

#region Filtering

//Console.WriteLine("Filter model :");

laptops[5].IsDeleted = true;

var initialQuery = laptops.Where(x => !x.IsDeleted);




var filter = new LaptopFilterModel("Asus", null, 14);f
var filteredLaptopsQuery = initialQuery.Where(laptop =>
{
    return laptop.Brand.Equals(filter.Brand)
           && (filter.Price is null || laptop.Price == filter.Price)
           && (filter.DisplaySize is null || laptop.DisplaySize == filter.DisplaySize);
});

//Console.WriteLine("Laptoplar boshlang'ich holati : ");
foreach (var laptop in filteredLaptopsQuery)
    Console.WriteLine($"Brand - {laptop.Brand}, Model - {laptop.Model}, Price - {laptop.Price}, Display size - {laptop.DisplaySize}");

Console.WriteLine();
//laptops.Add(new("Asus", "ZenBook 14 Pro", 899, 14));
laptops[5].IsDeleted = false;

foreach (var laptop in filteredLaptopsQuery)
    Console.WriteLine($"Brand - {laptop.Brand}, Model - {laptop.Model}, Price - {laptop.Price}, Display size - {laptop.DisplaySize}");

#endregion 

// Searching

// Pagination
// page size - sahifada nechta element borligi
// page token - hozir qaysi sahifadaligimiz
// total pages - umumiy nechta sahifa borligi

//var pageSize = 5;
//var pageToken = 0;
//var totalPages = laptops.Count / pageSize;

//while(pageToken++ < totalPages)
//{
//    Console.WriteLine(pageToken);
//    var response = laptops.Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
//    foreach(var item in response)
//        Console.WriteLine($"Brand - {item.Brand}, Model - {item.Model}, Price - {item.Price}, Display size - {item.DisplaySize}");
//}

public class Laptop
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }
    public int DisplaySize { get; set; }
    public bool IsDeleted { get; set; }

    public Laptop(string brand, string model, int price, int displaySize)
    {
        Brand = brand;
        Model = model;
        Price = price;
        DisplaySize = displaySize;
    }
}

// Value tiplarda default qiymat - 0, true, false
// Nullable - optional narsalar uchun default value 0 , true, false bo'lib qolmasligi uchun
public class LaptopFilterModel
{
    public string Brand { get; set; }
    public int? Price { get; set; }
    public int? DisplaySize { get; set; }

    public LaptopFilterModel(string brand, int? price, int? displaySize)
    {
        Brand = brand;
        Price = price;
        DisplaySize = displaySize;
    }
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Salary { get; set; }
    public int Kpi { get; set; }
}