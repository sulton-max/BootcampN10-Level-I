#region Constructor

// Konstruktor - objectlarni validatsiyadan o'tibgina yaratish uchun
// Static konstruktor - static tiplarni validatsiyadan o'tibgina dasturda ishlata olishimiz uchun

//Validator.TestMethod();-

using N18.PrivateCtor;

Console.WriteLine("Hi");

//Console.WriteLine(Validator.IsValidName(""));
var admin = new object();

Console.WriteLine(@"D:\Projects\Repositories\Company\NajotTalim\Groups\Bootcamp N10\BootcampN10-Level-I\N18\Program.cs".ToUrl());

var management = new LibraryManagement();
var managementB = new UltimateLibraryManagement(admin);

// Qoidalar
// Static - primitive, yengil va exceptionsiz logikalar
// Singleton object - logika ko'pgina objectlarda farq qilmasa
// Multiple object - agar logika yoki ma'lumot har bitta objectda har xil bo'lsa

var emailService = EmailService.GetInstance();
var emailServiceA = EmailService.GetInstance();
var emailServiceB = EmailService.GetInstance();
var emailServiceC = EmailService.GetInstance();


#endregion