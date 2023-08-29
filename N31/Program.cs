//(Index based access, Conversion, Combining and Joining )

using N31;

var users = new List<User>();
users.Add(new("John", "jonibek", 10));
users.Add(new("Michael", "Mike", 32));
users.Add(new("Jimmy", "Jim", 21));
users.Add(new("Alexander", "Alex", 23));
users.Add(new("Alexander", "Alex", 23));

// Index based access
// var testA = list.ElementAt(10); // has exception if index is invalid

// ElementAt - index bo'yicha elementni olish topilsa, topilmasa exception
// ElementAtOrDefault - index bo'yicha elementni olish topilsa, topilmasa default qiymat

var testB = users.ElementAtOrDefault(10);
Console.WriteLine(testB);

var validUsersIndex = users.Select((user, index) => user.Age > 18 ? index : -1).Where(index => index != -1).ToList();
validUsersIndex.ForEach(index => Console.WriteLine(users.ElementAt(index)));

// Conversion
// ToList - kolleksiyani listga o'tkazish
// ToDictionary - dictionary ga o'tkazish
// ToHashSet - hashset ga o'tkazish
// ToLookUp - guruhlangan kolleksiyaga o'tkazish
// AsEnumerable - faqat sanash mumkin bo'lgan kolleksiyaga o'tkazadi
// AsQueryable - query qilish mumkkin bo'lgan kolleksiyaga o'tkazadi

// Dictionary<string, User>

var customDictionary = new Dictionary<Guid, string>();
// userlarni custom dictionary ga qo'shish - Id va FirstName bilan
users.ForEach(user => customDictionary.Add(user.Id, user.FirstName));

// tepadagini oson usuli
var usersDictionary = users.ToDictionary(user => user.Id, user => user.FirstName);

// ToHashSet - hashset qiymatlari bor kolleksiya
Console.WriteLine();
Console.WriteLine("ToHashSet");
var usersHash = users.ToHashSet();
foreach (var user in usersHash)
    Console.WriteLine(user);

// ToLookUp - guruhlangan kolleksiya
Console.WriteLine();
Console.WriteLine("ToLookUp");
var usersLookup = users.ToLookup(user => user.Role);
foreach (var roleGroup in usersLookup)
{
    Console.WriteLine($"Role : {roleGroup.Key}");
    foreach (var user in roleGroup)
        Console.WriteLine(user);
}

// AsEnumerable
var usersEnumerable = users.AsEnumerable();

foreach (var user in usersEnumerable)
    Console.WriteLine(user);

// IQueryable - query qilish uchun maxsus kolleksiya turi
// AsQueryable - query qilish uchun maxsus kolleksiya turi

// In memory collection + Database source -> IQueryable

var usersQueryable = users.Where(user => user.Age > 18).AsQueryable();
usersQueryable = usersQueryable.Where(user => user.Role == "Admin");

foreach (var user in usersQueryable)
    Console.WriteLine(user);

foreach (var user in usersQueryable)
    Console.WriteLine(user);

namespace N31
{
    public class Test
    {
        // IList - index
        // ICollection - add, remove
        // IEnumerable - foreach
        public void SendEmails(IEnumerable<User> users)
        {
            foreach(var user in users)
            {
                Console.WriteLine("Sending email ...");
            }
        }
    }








    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }

        public User(string firstName, string userName, int age)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            FirstName = firstName;
            Age = age;

            var random = new Random();
            Role = random.Next(0, 2) == 0 ? "Admin" : "User";
        }

        public override string ToString()
        {
            return $"{FirstName} {Age}";
        }

        public override int GetHashCode()
        {
            // 17 va 23 siz GetHashCode ni qiymati mana bunday bo'lur

            // Alex   23 yosh              23423234
            // Alexa  23 yosh              23424234


            // 17 va 23 bilan GetHashCode ni qiymati mana bunday bo'lur

            // Alex   23 yosh              23423234
            // Alexa  23 yosh              53277428

            var hash = 17;
            hash = hash * 23 + FirstName.GetHashCode();
            hash = hash * 23 + UserName.GetHashCode();
            hash = hash * 23 + Age.GetHashCode();

            return hash;
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }
    }
}