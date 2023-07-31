using Library;
using N14;
using N14.OverridingExample;
using PasswordGenerator = N14.OverridingExample.PasswordGenerator;

#region Polymorhism - Overriding

// Overload - compile time
// Override - runtime

// Shart - har bitta hayvonni o'zini ovozi bo'lishi

// Eski usul - har bitta method alohida e'lon qilish

// Xato yechimlar :
// - har bitta tipda alohida method ochish - bunda childda kerakmas methodlar bo'ladi - version 1
// - parent tipda parameter qo'shish - hamma logika parent tipda bo'ladi

// To'g'ri yechimlar :
// New Method - shunchaki e'lon qilishimiz mumkin ( warning ) yoki new keyword - version 2
// Override - parentda virtual va childda override qilingan bo'lishi kerak, parentda e'lon qilingan methodni childda o'zgartiramiz - version 3

// Version 1 - har bitta method alohida e'lon qilish usuli
Console.WriteLine("Alohida methodlardan foydalanganda : ");
Console.WriteLine();

var sparrow = new N14.SeparateMethods.Sparrow();
Console.Write("sparrow.MakeSoundAsSparrow() - ");
sparrow.MakeSoundAsSparrow();

Console.Write("sparrow.MakeSoundAsBird() - ");
sparrow.MakeSoundForBird(); // bu method sparrow ichida bo'lishi mumkinmas

Console.Write("sparrow.MakeSound() - ");
sparrow.MakeSound(); // bu method sparrow ichida bo'lishi mumkinmas

Console.WriteLine();

// Child tipidagi objectni Parent va o'zini tipida saqlash
// Version 2 - duplicate methodlar e'lon qilamiz

Console.WriteLine("Duplicate methodlardan foydalanganda : ");
Console.WriteLine();

N14.DuplicateMethods.Animal sparrowA = new N14.DuplicateMethods.Sparrow();
N14.DuplicateMethods.Bird sparrowB = new N14.DuplicateMethods.Sparrow();
N14.DuplicateMethods.Sparrow sparrowC = new N14.DuplicateMethods.Sparrow();

Console.Write("sparrowA.MakeSound() - ");
sparrowA.MakeSound();

Console.Write("sparrowB.MakeSound() - ");
sparrowB.MakeSound();

Console.Write("sparrowC.MakeSound() - ");
sparrowC.MakeSound();

Console.WriteLine();

// Version 2 - overriding
Console.WriteLine("Overridingdan foydalanganda : ");
Console.WriteLine();

N14.OverridingMethods.Animal sparrowD = new N14.OverridingMethods.Sparrow();
N14.OverridingMethods.Bird sparrowE = new N14.OverridingMethods.Sparrow();
N14.OverridingMethods.Sparrow sparrowF = new N14.OverridingMethods.Sparrow();

Console.Write("sparrowD.MakeSound() - ");
sparrowD.MakeSound();

Console.Write("sparrowE.MakeSound() - ");
sparrowE.MakeSound();

Console.Write("sparrowF.MakeSound() - ");
sparrowF.MakeSound();

Console.WriteLine();

// Override example

Console.WriteLine("Overriding ga misol : Generate methodi override qilingan ");
Console.WriteLine();

Console.WriteLine($"new UniquePasswordGenerator(8, true, true).Generate() - {new PasswordGenerator(8, true, true).Generate()}");
Console.WriteLine($"new SecurePasswordGenerator(8, true, true, true).Generate() - {new SecurePasswordGenerator(8, true, true, true).Generate()}");

#endregion

#region Encapsulation

// OOP - Object Oriented Programming 
// Inheritance - vorislik
// Polymorphism - behaviorni har xil formasi
// Encapsulation - inkapsulatsiya, nimanidir yashirish

// Black Box - faqat komanda beriladigan va rezultat olinadigan quti, uni qanday ishlashini bilmaymiz

// Nimani yashiriladi -
//
// Service - asosiy modellarni va tashqaridan ishlatilishi ta'qiqlangan methodlarni
// Model - fieldlar


// Nega yashirish kerak


// Model -  Invalid qiymatli fieldlar - borligiga ta'sir qiladi

// Encapsulation dan foydalanish usullari
//- `Access Modifiers` - `public`, `private`, `protected`, `internal` modifiers
//- `Properties(or Getter / Setters)` -exposes private fields by public getter/ setter
//- `Interfaces` - hiding implementation by implementing public members from interfaces
//- `Data Hiding` - hiding internal data and providing public methods to interact with
//- `Encapsulating Complex Behavior` - grouping related behavior and providing well-

var generator = new UniquePasswordGenerator();
Console.WriteLine();

Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());

// generator.Clear();  - bu method public bo'lganligi uchun muammo keltirib chiqarish ehtimoli bor, chunki tashqaridan ishlatilishi mumkin, uni private qilish kerak

Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());
Console.WriteLine(generator.Generate());

// Access Modifier

// public - hamma uchun ochiq
// protected - child tiplar hammasi ochiq
// private - faqat tip uchun ochiq
// internal - faqat project uchun ochiq
// internal protected - faqat project uchun yoki child tip uchun ochiq
// private protected - faqat project ichidagi childlar uchun ochiq

// internal protected - internal or protected - 
// private protected - internal and protected - 

var teachingSystem = new TeachingSystem();
var onlineTeachingSystem = new OnlineTeachingSystem();

var validator = new Validator();

// public - hamma tip, field va boshqalarga ishlaydi
teachingSystem.DisplayCourses();

// protected - voris olgan tiplarda murojaat qilsa bo'ladi
onlineTeachingSystem.DisplayPlans();

// private - faqat tip ichida murojaat qilish mumkin
// teachingSystem.DisplayBalance(); // invisible - private
teachingSystem.SendStatisticsToBoss("sdfsdf");

// internal - faqat project ichida murojaat qilish mumkin
//validator.Regex = new Regex("234234"); // invisible - internal

#endregion