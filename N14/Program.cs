﻿#region Polymorhism - Overriding 

//var sparrow = new Sparrow();
//sparrow.MakeSoundForBird();
//sparrow.MakeSound();

// Multilevel inheritance

// Shart - har bitta hayvonni o'zini ovozi bo'lishi
// Xato usullari
// - har bitta tipda alohida method ochish - bunda childda kerakmas methodlar bo'ladi
// - parent tipda parameter qo'shish - hamma logika parent tipda bo'ladi

// Eski usul
//public class Animal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("...");
//    }
//}

//public class Bird : Animal
//{
//    public void MakeSoundForBird()
//    {
//        Console.WriteLine("sayramoq");
//    }
//}

//public class Sparrow : Bird
//{
//    public void MakeSoundAsSparrow()
//    {
//        Console.WriteLine("g`ishtmat");
//    }
//}


// Override - runtime
// New Method - child tip ichida override qilmasdan o'zini logikasini ishlatish


// Ishlatish usuli
// New Method - shunchaki e'lon qilishimiz mumkin ( warning ) yoki new keyword
// Override - parentda virtual va childda override qilingan bo'lishi kerak

// parentda e'lon qilingan methodni childda o'zgartiramiz
// 

// Child tipidagi objectni Parent va o'zini tipida saqlash

// Version 1 - new method

//Animal sparrowA = new Sparrow();
//Bird sparrowB = new Sparrow();
//Sparrow sparrowC = new Sparrow();

//sparrowA.MakeSound();
//sparrowB.MakeSound();
//sparrowC.MakeSound();

//public class Animal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("...");
//    }
//}

//public class Bird : Animal
//{
//    public new void MakeSound()
//    {
//        Console.WriteLine("Making sound as bird");
//    }
//}

//public class Sparrow : Bird
//{
//    public new void MakeSound()
//    {
//        Console.WriteLine("Making sound as sparrow");
//        Console.WriteLine("Making sound as sparrow");
//        Console.WriteLine("Making sound as sparrow");
//        Console.WriteLine("Making sound as sparrow");
//        Console.WriteLine("Making sound as sparrow");
//    }
//}

// Version 2 - new method
//Animal sparrowA = new Sparrow();
//Bird sparrowB = new Sparrow();
//Sparrow sparrowC = new Sparrow();

//sparrowA.MakeSound();
//sparrowB.MakeSound();
//sparrowC.MakeSound();


//public class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("...");
//    }
//}

//public class Bird : Animal
//{
//    //public virtual void MakeSound()
//    //{
//    //    Console.WriteLine("Making sound as bird");
//    //}
//}

//public class Sparrow : Bird
//{
//    public override void MakeSound()
//    {
//        base.MakeSound();
//        Console.WriteLine("Making sound as sparrow");
//    }
//}

// Override example
//using System.Text;

//var generator = new SecurePasswordGenerator(4, true, true, true);
//Console.WriteLine(generator.Generate());

//public class PasswordGenerator
//{
//    public readonly int length;
//    public readonly bool hasLetters;
//    public readonly bool hasDigits;


//    public PasswordGenerator(int length, bool hasLetters, bool hasDigits = false)
//    {
//        if (length < 4 || (hasLetters == false && hasDigits == false))
//            throw new ArgumentException();

//        this.length = length;
//        this.hasLetters = hasLetters;
//        this.hasDigits = hasDigits;
//    }

//    // a - z - 97 - 122
//    // A - Z - 65 - 90
//    public virtual string Generate()
//    {
//        var random = new Random();
//        var password = new StringBuilder();

//        for (var index = 0; index < length;)
//        {
//            if (hasDigits && random.Next(0, 2) == 0)
//            {
//                var randomDigit = random.Next(0, 10);
//                password.Append(randomDigit);

//                index++;
//            }
//            else if (hasLetters)
//            {
//                var randomChar = random.Next(0, 1) == 0
//                    ? (char)random.Next(97, 123)
//                    : (char)random.Next(65, 91);

//                index++;

//                password.Append(randomChar);
//            }
//        }

//        return password.ToString();
//    }
//}

//public class SecurePasswordGenerator : PasswordGenerator
//{
//    private readonly bool hasSymbols;

//    public SecurePasswordGenerator(int length, bool hasLetters, bool hasSymbols, bool hasDigits = false)
//        : base(length, hasLetters, hasDigits)
//    {
//        this.hasSymbols = hasSymbols;
//    }

//    public override string Generate()
//    {
//        var random = new Random();
//        var password = new StringBuilder();

//        for (var index = 0; index < length;)
//        {
//            var randomChoice = random.Next(0, 3);

//            if (hasDigits && randomChoice == 0)
//            {
//                var randomDigit = random.Next(0, 10);
//                index++;

//                password.Append(randomDigit);
//            }
//            else if (hasLetters && randomChoice == 1)
//            {
//                var randomChar = random.Next(0, 1) == 0
//                    ? (char)random.Next(97, 123)
//                    : (char)random.Next(65, 91);
//                password.Append(randomChar);

//                index++;

//            }
//            else if (hasSymbols && randomChoice == 2)
//            {
//                var randomSymbol = (char)random.Next(33, 48);
//                password.Append(randomSymbol);

//                index++;

//            }
//        }

//        return password.ToString();
//    }
//}

#endregion

#region Encapsulation

// OOP - Object Oriented Programming 
// Inheritance - vorislik
// Polymorphism - behaviorni har xil formasi
// Encapsulation - inkapsulatsiya, nimanidir yashirish

// Black Box - faqat komanda beriladigan va rezultat olinadigan quti, uni qanday ishlashini bilmaymiz

// Nimani yashiriladi -
//
// Service - asosiy modellarni va taqiqlangan methodlar
// Model - fieldlar

// Encapsulation dan foydalanish usullari
//- `Access Modifiers` - `public`, `private`, `protected`, `internal` modifiers
//- `Properties(or Getter / Setters)` -exposes private fields by public getter/ setter
//- `Interfaces` - hiding implementation by implementing public members from interfaces
//- `Data Hiding` - hiding internal data and providing public methods to interact with
//- `Encapsulating Complex Behavior` - grouping related behavior and providing well-




//var planner = new Planner();

//var user = new User("John", "test@mgmail.com", 32);

//user._emailAddress = "";

//using System.Text;
//using N14;

//var generator = new PasswordGenerator();

//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());

////generator.Clear();

//// Do something

//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());
//Console.WriteLine(generator.Generate());

// Access Modifier

// public - hamma uchun ochiq
// protected - child tiplar hammasi ochiq
// private - faqat tip uchun ochiq
// internal - faqat project uchun ochiq
// internal protected - faqat project uchun yoki child tip uchun ochiq
// private protected - faqat tip uchun yoki child uchun ochiq

// internal protected - internal or protected
// private protected - internal and protected

//planner.DailyEvents[""] = 

// Model -  Invalid qiymatli fieldlar - borligiga ta'sir qiladi

using System.Text.RegularExpressions;
using Library;
using N14;

var teachingSytem = new TeachingSystem();
var onlineTeachingSystem = new OnlineTeachingSystem();
var validator = new Validator();

// public
teachingSytem.DisplayCourses();

// protected
onlineTeachingSystem.DisplayPlans();

// private
//teachingSytem.DisplayBalance(); // invisible
teachingSytem.SendStatisticsToBoss("sdfsdf");

// internal
//validator.Regex = new Regex("234234"); // invisible

public class SuperValidator : Validator
{
    // internal or protected
    public SuperValidator()
    {
        EmailAddressRegex = new Regex("678"); // tezroq ishlaydigan regex

        // private protected
        //FirstNameRegex = new Regex("678");
    }
}



//teachingSytem.PlanOtherCourses() // not visible



#endregion