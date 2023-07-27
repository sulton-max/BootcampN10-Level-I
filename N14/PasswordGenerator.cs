#region Polymorhism - Overriding 

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


//- `Access Modifiers` - `public`, `private`, `protected`, `internal` modifiers
//- `Properties(or Getter / Setters)` -exposes private fields by public getter/ setter
//- `Interfaces` - hiding implementation by implementing public members from interfaces
//- `Data Hiding` - hiding internal data and providing public methods to interact with
//- `Encapsulating Complex Behavior` - grouping related behavior and providing well-





//var planner = new Planner();

//var user = new User("John", "test@mgmail.com", 32);

//user._emailAddress = "";

// Public ta'qiqlangan methodlar - ishlashiga ta'sir qiladi


public class PasswordGenerator
{
    public List<string> Passwords;

    public PasswordGenerator()
    {
        Passwords = new List<string>();
    }

    internal  string Generate()
    {
        var password = "password";

        //if (Passwords == null)
        //    Passwords = new List<string>();

        Passwords.Add(password);
        return password;
    }

    // tashqaridan ishlatilishi ta'qiqlangan method
    private void Clear()
    {
        Passwords = null;
    }

    public void Reset()
    {
        Clear();
        Passwords = new List<string>();
    }
}



#endregion