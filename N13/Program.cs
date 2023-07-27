#region Inheritance

// code reuse - code bitta joyda yozish va qayta ishlatish
// abstraction - abstraksiya
// inheritance - vorislik
// vorislikda - data va behavior    

// this
// base

//var bmw = new BMW("X5");

// Object initialization syntax - ixtiyoriy
// new Type
// {
//   Member = value
// }
//

//var porsche = new Porsche();

//bmw.Drive();
//porsche.Drive();

//public class Vehicle
//{
//    public void Drive()
//    {
//        Console.WriteLine("Starting the engine");
//        Console.WriteLine("Accelerating");
//    }
//}

//public class BMW : Vehicle
//{
//    public string Model { get; set; }

//    // Constructor
//    // Tipdan object olganda ishlaydi
//    // Tip nomi bilan bir xil
//    // Vazifasi - boshlang'ich vazifalarni bajarish
//    // Hech nima qaytarmaydi
//    public BMW(string model)
//    {
//        Model = model;

//        Console.WriteLine("Showing BMW logo");
//        Drive();
//        Console.WriteLine("Checking door");
//    }

//    // this ni ishlatilishi
//    //public void Test(BMW value)
//    //{
//    //    Console.WriteLine(value.Model);
//    //    Console.WriteLine(this.Model);
//    //}

//    // this ni ishlatilishi
//    //public void Test(string Model)
//    //{
//    //    this.Model = Model;
//    //}
//}

//public class Porsche : Vehicle
//{

//}

// base constructor

#endregion

#region Polymorphism

using System.Reflection.Metadata.Ecma335;

var calculator = new Calculator();

// Eski usul
//calculator.Add((int)10.5D, (int)10.4D);

// Polymorphism - bitta narsani har xil formasi
// Logika har xil bo'lishi mumkin, vazifasi bir xil bo'ladi

// Overload - compile time - bir xil nomli methodlarni har xil versiyasi
// Constructor overloading
// Method overloading

//Console.WriteLine(calculator.Add(10, 10));
//Console.WriteLine(calculator.Add(10.5D, 10.4D));

//calculator.Add("textA", "textB");

//var userA = new User("John", "Doe");
//var userB = new User("John", "Doe", "Jones");
//var userC = new User("John", "Doe", "Jones", 32);

//Console.WriteLine(userA);
//Console.WriteLine(userB);
//Console.WriteLine(userC);

var interviewerA = new Interviewer("John", "Doe");
var interviewerB = new Interviewer("John", "Doe", "Jones");

public class Calculator
{
    public int Add(int valueA, int valueB)
    {
        return valueA + valueB;
    }

    public double Add(double valueA, double valueB)
    {
        return valueA + valueB;
    }

    public double Add(double valueA, double valueB, double valueC)
    {
        return valueA + valueB + valueC;
    }

    //public string Add(string valueA, string valueB)
    //{
    //    Console.WriteLine("2 talik");
    //    return valueA + valueB;
    //}

    // Optional parameter - boshlang'ich qiymati bor bo'lgan parameteri
    // Params parameter - 
    public string Add(string valueA, string valueB, string valueC = "")
    {
        Console.WriteLine("3 talik");
        return valueA + valueB + valueC;
    }

    // Mumkinmas holatlar 
    // faqat parameter nomi bilan farq qilsa
    // faqat return tipi farq qilsa
    //public double Add(double valueA, double valueC)
    //{
    //    return valueA + valueB;
    //}
    //public decimal Add(double valueA, double valueB)
    //{
    //    return valueA + valueB;
    //}
}

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }

    // Default constructor
    //public User()
    //{
    //    // Do something
    //}

    // Constructor overloading
    public User(string firstName, string lastName, string middleName = "")
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;

        Console.WriteLine("Userdagi 1-konstruktor ishladi");
    }

    // this - konstruktorni boshqa versiyasini chaqiradi
    public User(string firstName, string lastName, string middleName, int age)
        : this(firstName, lastName, middleName)
    {
        Age = age;

        Console.WriteLine("Userdagi 2-konstruktor ishladi");
    }

    public override string ToString()
    {
        return $"{FirstName} {MiddleName} {LastName} {Age}";
    }
}

public class Interviewer : User
{
    public Interviewer(string firstName, string lastName, string middleName = "")
        : base(firstName, lastName, middleName)
    {
        Console.WriteLine("Interviewerdaig 1-konstruktor ishladi");
    }
}

// Overload



// Override

#endregion