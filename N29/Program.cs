// Concurrency -  dasturni bir paytni o'zida bir nechta ishni bajarish qobiliyati
// Buni bajarish usullari - multithreading, asynchronous programming
// Asynchronous programming - async / await va Task usullari bor

// Asinxron bajariladigan methodlar nomida Async postfix bo'ladi

// Main methodi main threadda boshlanadi, ishlaydi va ishini shunda tugatadi
// Main threaddan turib boshqa threadlarga ishlar bo'lib beriladi

// Asinxron methodni return tipi - Task yoki Task<T>
// Task - asinxron bajarilayotgan narsani statusi va resultati ushlab turadigan tip

using System.Text;
using N29.Services;

// Console.WriteLine("Enter your email address: ");
// var userEmail = Console.ReadLine();
//
// var emailService = new EmailService();

var emailAddresses = new List<string>
{
    "jasurabdulxaev@gmail.com",
    "abdura52.uz@gmail.com",
    "toshmurodovj13@gmail.com",
    "kbunyod3011@gmail.com",
    "azamamonov555@gmail.com",
    "abdurahmonsadriddinov0412@gmail.com",
    ".com"
};

// var random = new Random();
// foreach(var userName in userNames)
// {
//     Console.WriteLine(userName);
//     var result = Task.Run(() =>
//     {
//         // 10 daqiqalik ish
//         Thread.Sleep(random.Next(1, 4) * 1000);
//         Console.WriteLine($"{userName} uchun file yaratildi");
//     });
//
//     Console.WriteLine("Keyingi user uchun ish bajarilmoqda");
// }

// hech nima qaytarmaydigan method - void
// hech nima qaytarmaydigan methodni asinxron versiyasi - Task

// nimadir qaytaradigan method - User
// nimadir qaytaradigan methodni asinxron versiyasi - Task<List<User>>>

// nimadir

// bir nechta yaratilgan tasklarni kutish
// Task.WaitAll() - Task[] - hech nima qaytarmaydigan methodlar uchun ( void
// Task.WhenAll() - Task<T>[] - nimadir qaytaradigan methodlar uchun

// Thread to'xtatish - killing a thread yoki terminating a thread

var emailService = new EmailService();

// Task 1 - userllar fayllar ochish
var createFileTasks = emailAddresses.Select(user => Task.Run(() =>
{
    // var name = user.Substring(0, user.IndexOf('@'));
    var fileStream = File.Create($"{user.ToLower()}.docx");
    Console.WriteLine($"{user} ga fayl yaratildi");
    return fileStream;
}));

// Task 2 - userlarga email jo'natish
var sendRegistrationEmailTasks = emailAddresses.Select(async emailAddress =>
{
    var result = await emailService.SendAsync(emailAddress, "Confirm you account", "Enter to this link");
    Console.WriteLine($"{emailAddress} ga email jo'natish resultati - {result}");
    return result;
});

// Task 3 - userlar fayllarini tayyorlash
var userFiles = (await Task.WhenAll(createFileTasks)).ToList();
var writeToFileTasks = userFiles.Select(file =>
{
    var message = $"Hurmatli {file.Name}, bu xabarda blah, blah, blah ";
    return file.WriteAsync(Encoding.UTF8.GetBytes(message));
});

// Task 4 - userlarga fayllari tayyor bo'lganini xabar berish
var sendEmailResults = await Task.WhenAll(sendRegistrationEmailTasks);
Console.WriteLine(
    $"{sendEmailResults.Length} dan {sendEmailResults.Count(sendEmailResults => sendEmailResults)} tasi ga email to'g'ri jo'natildi");

// Task 5 - userlarga fayllarini tayyor bo'lganini xabar berish
Task.WaitAll(writeToFileTasks.Select(task => task.AsTask()).ToArray());
var sendCompletionEmailTasks = emailAddresses.Select(async emailAddress =>
{
    var result = await emailService.SendAsync(emailAddress, "Fayl completed", "Your file is ready");
    Console.WriteLine($"{emailAddress} ga email jo'natish resultati - {result}");
    return result;
});

await Task.WhenAll(sendCompletionEmailTasks);


// var first = createFileTasks.First();
// first.Wait();
// first.Result;

// foreach (var message in userFiles)
// {
//     Console.WriteLine(message);
// }


// userFiles.