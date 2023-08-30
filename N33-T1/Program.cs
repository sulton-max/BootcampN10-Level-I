// using N33_T1.Models.Entities;
// using N33_T1.Services.Accounts.Interfaces;
//
// var builder = WebApplication.CreateBuilder(args);
//
// var app = builder.Build();
//
// app.MapGet("/", () => "Hello World!");
//
// app.Run();

int[] numbers =
{
    1,
    2,
    3,
    4,
    5
};
// var query = numbers.AsQueryable();

// var query = numbers.AsQueryable();
// query = query.Where(number => number % 2 == 0);
//
// foreach (var number in query)
//     Console.WriteLine(number);
//
// foreach (var number in query)
//     Console.WriteLine(number);
//
//
// IList
// var result = Test.Get();
//
// foreach (var number in Test.GetOddNumbers(new Queue<int>(new [] {1,2,3,3})))
//     Console.WriteLine(number);
//
// foreach (var number in result)
//     Console.WriteLine(number);
//
// public static class Test
// {
//     public static List<int> GetOddNumbers(IList<int> numbers) => numbers.Where(number => number % 2 != 0).ToList();
// }

// Where(number => number % 2 == 0)

var users = new List<User>()
{
    new User
    {
        EmailAddress = "john"
    },
    new User
    {
        EmailAddress = "doe"
    },
    new User
    {
        EmailAddress = "jonibek"
    },
    new User
    {
        EmailAddress = "g'ishtmat"
    },
};

var filter = new UserFilterModel()
{
    SearchKeyword = "john.doe@gmail.com",
    AgeGreaterThan = 30
};

foreach (var user in users.Skip(2))
    Console.WriteLine(user);

Console.WriteLine();

foreach (var user in users.SkipLast(2))
    Console.WriteLine(user);

Console.WriteLine();

foreach(var user in users.SkipWhile((user, index) => index % 2 == 0))
    Console.WriteLine(user);

//
// var initialQuery = users.AsQueryable();
// var filterQuery =
//     initialQuery.Where(user => user.Age >= filter.AgeGreaterThan && user.EmailAddress == filter.SearchKeyword);

public class User
{
    public string EmailAddress { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"Email: {EmailAddress}, Age: {Age}";
}

public class UserFilterModel
{
    public string? SearchKeyword { get; set; }
    public int? AgeGreaterThan { get; set; }
    public bool IsAdmin { get; set; }
}