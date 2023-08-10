// var emailService = EmailService.GetInstance();
// var factory = new SingletonFactory<EmailService>();
//
// var calculator = new Calculator();
// var a = 10;
// var b = 20;
//
// var userA = new User();
// var userB = new User();
//
// calculator.Add(userA, userB);
// calculator.Add(new object(), new object());
// calculator.Add(DateTime.Now, DateTime.Now);
// calculator.Add(Guid.NewGuid(), Guid.NewGuid());
//
// public class User
// {
//     public User(string firstName, string lastName)
//     {
//     }
//
//     public User(string firstName, string lastName, string userName) : this(firstName, userName)
//     {
//     }
//
//     public User()
//     {
//     }
// }
//
// public class Calculator
// {
//     // poliformizm - bitta vazifani har xil usul bilan qilish
//     // overload - return tipi har xil bo'lsa overload bo'lmaydi
//
//     // logika bir xil
//     // formasi har xil
//
//
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }
//     //
//     // public double Add(double a, double b)
//     // {
//     //     return a + b;
//     // }
//
//     public void Add<TValue>(TValue valueA, TValue valueB) where TValue : ICloneable
//     {
//         if (valueA is int intValueA && valueB is int intValueB)
//         {
//             Console.WriteLine(intValueA + intValueB);
//         }
//     }
// }
//
// var test = new List<int>();
// test.Add();
//
// var inventory = new Inventory<IItem>();
// inventory.Add(new Treasure("Olmos", "olmos.jpg", 20));
// inventory.Add(new Weapon("AK-47", "ak.jpg", 40));
// inventory.Add(new Treasure("Gold", "gold.jpg", 30));
// inventory.Add(new Weapon("M-416", "m-416.jpg", 30));
// inventory.Add(new Potion("Eliksir", "eliksir.png", 30));
// inventory.Add(new Potion("Super Eliksir", "super-eliksir.png", 20));
// inventory.Add(new Treasure("UC", "uc.jpg", 10));
//
// var treasures = inventory.GetTreasures();
// foreach(var treasure in treasures)
// {
//     Console.WriteLine(treasure.Name);
// }
//
// Console.WriteLine("dastur tugadi");
//
// public interface IItem
// {
//     string Name { get; }
//     string Picture { get; }
// }
//
// public class Weapon : IItem
// {
//     public string Name { get; set; }
//     public string Picture { get; }
//     public int Damage { get; set; }
//
//     public Weapon(string name, string picture, int damage)
//     {
//         Name = name;
//         Picture = picture;
//         Damage = damage;
//     }
// }
//
// public class Potion : IItem
// {
//     public string Name { get; }
//     public string Picture { get; }
//     public int Health { get; }
//
//     public Potion(string name, string picture, int health)
//     {
//         Name = name;
//         Picture = picture;
//         Health = health;
//     }
// }
//
// public class Treasure : IItem
// {
//     public string Name { get; }
//     public string Picture { get; }
//     public int Value { get; }
//
//     public Treasure(string name, string picture, int value)
//     {
//         Name = name;
//         Picture = picture;
//         Value = value;
//     }
// }

// Generic - umumiy tipi ma'lummas

// Field yoki Property generic bo'lsa - o'sha tipni o'zi generic bo'lishi shart
// Method generic bo'lsa - o'sha tip generic bo'lishi shartmas

// Oddiy parameter - value uchun placeholder
// Type parameter - tip uchun placeholder

// public class Inventory<TItem> where TItem : IItem, ICloneable
// {
//     private readonly List<TItem> _items = new();
//
//     public void Add(TItem item)
//     {
//         _items.Add(item);
//     }
//
//     public List<Treasure> GetTreasures()
//     {
//         var test = _items[0];
//
//         // is - agar test Treasure bo'lsa titem ga o'giradi
//         // is - oldin tekshiradi - true bo'lsa konvert qiladi
//         if (test is Treasure titem)
//         {
//             // Do something
//         }
//
//         // as - agar test Treasure bo'lsa titem ga o'giradi
//         // as - oldin tekshiradi - true bo'lsa konvert qiladi, yo'qsa null qaytaradi
//         var tItemB = test as Treasure;
//         if (tItemB != null)
//         {
//
//         }
//
//         // Select - har bitta element uchun ishlaydi va ularni boshqa narsaga konvert qiladi
//         // OfType - bitta kolleksiya ichidan kerakli tipdagi narsalarni filter qilib beradi
//
//         return _items.OfType<Treasure>().ToList();
//     }
// }


// public class SingletonFactory<T>
// {
//     public SingletonFactory()
//     {
//         new EmailService();
//     }
// }
//
//
// public class EmailService
// {
//     private static EmailService _instance;
//
//     private EmailService()
//     {
//     }
//
//     public static EmailService GetInstance()
//     {
//         if (_instance == null)
//             _instance = new EmailService();
//
//         return _instance;
//     }
// }
//
// public class AccountService
// {
// }

//
// var usersGroupA = new List<User>();
// var usersGroupB = new List<User>();
//
// var aggregator = new CollectionAggregator();
// var unionGroup = aggregator.Union(usersGroupA, usersGroupB);
//
//
// public class User : IEqualityComparer<User>
// {
//     public bool Equals(User x, User y)
//     {
//         throw new NotImplementedException();
//     }
//
//     public int GetHashCode(User obj)
//     {
//         throw new NotImplementedException();
//     }
// }
//
// public interface ICollectionAggregator
// {
//     List<T> Concat<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>;
//
//     List<T> Intersect<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>;
//
//     List<T> Except<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>;
//
//     List<T> Union<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>;
// }
//
// public class CollectionAggregator : ICollectionAggregator
// {
//     public List<T> Concat<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>
//     {
//         throw new NotImplementedException();
//     }
//
//     public List<T> Intersect<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>
//     {
//         throw new NotImplementedException();
//     }
//
//     public List<T> Except<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>
//     {
//         throw new NotImplementedException();
//     }
//
//     public List<T> Union<T>(List<T> list1, List<T> list2) where T : IEqualityComparer<T>
//     {
//         throw new NotImplementedException();
//     }
// }
//

// when - try-catch, switch expression
// where - generics
// while - loop

// var list = new List<int>();
