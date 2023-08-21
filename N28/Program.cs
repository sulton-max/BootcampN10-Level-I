// generics - files
// generics - data, behavior
// generics - constraint - limit - where
// generics - extension method
// generic interface
// generic static members

using N28.DataAccess.Contexts;
using N28.Models.Entities;

var fileContext = new FileDataContext();

// fileContext.Posts.Add(new BlogPost(".NET yoki Node.js?", "Bu postda .NET va Node.js haqida gaplashamiz", ""));
// fileContext.Posts.Add(new BlogPost("AR or VR?", "Bu postda ", ""));
//
// fileContext.SaveChanges();

// unmodified
// foreach (var post in fileContext.Posts)
//     Console.WriteLine(post);
//
// // added
// fileContext.Posts.Add(new("JS yoki TS ? ", "Bu postda JS va TS haqida gaplashamiz", ""));
//
// // deleted
// var deleted = fileContext.Posts[70];
// fileContext.Posts.Remove(deleted);
//
// // updated
// var updated = fileContext.Posts.First();
// updated.Content = "Vision Pro va Hololens haqida gaplashamiz";

// fileContext.SaveChanges();

// concurrency

// ecommerce

// fileContext.Users.Add(new User("John", "Doe"));
// fileContext.Users.Add(new User("Jane", "Doe"));
//
// fileContext.Posts.Add(new(".NET yoki Node.js",
//     "Bugun sizga .NET yoki Node.js dasturlash tillari orasidagi tanlovingizni qilishni taklif qilaman. Bu tanlovda sizga 2ta dasturlash tillari orasidan birini tanlash kerak.",
//     "", fileContext.Users.First().Id));
// fileContext.Posts.Add(new("AR yoki VR",
//     "Bugun sizga .NET yoki Node.js dasturlash tillari orasidagi tanlovingizni qilishni taklif qilaman. Bu tanlovda sizga 2ta dasturlash tillari orasidan birini tanlash kerak.",
//     "", fileContext.Users[1].Id));
//
// fileContext.SaveChanges();

// var john = fileContext.Users.FirstOrDefault(user => user.FirstName.Contains("John"));
// var jane = fileContext.Users.FirstOrDefault(user => user.FirstName.Contains("Jane"));
//
// var johnsPosts = fileContext.Posts.Where(post => post.AuthorId == john.Id).ToList();
// var janesPosts = fileContext.Posts.Where(post => post.AuthorId == jane.Id).ToList();
//
// Console.WriteLine("John's posts");
// foreach (var post in johnsPosts)
//     Console.WriteLine(post);
//
// Console.WriteLine();
//
// Console.WriteLine("Jane's posts");
// foreach (var post in janesPosts)
//     Console.WriteLine(post);





