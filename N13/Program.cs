#region Inheritance

// code reuse - code bitta joyda yozish va qayta ishlatish
// abstraction - abstraksiya
// inheritance - vorislik
// vorislikda - data va behavior    

// this
// base

using N13;

var bmw = new Bmw("X5");

// Object initialization syntax - ixtiyoriy
var porsche = new Porsche();

bmw.Drive();
porsche.Drive();

// base constructor

#endregion

#region Polymorphism - Method overloading

var calculator = new Calculator();

// Eski usul
//calculator.Add((int)10.5D, (int)10.4D);

// Polymorphism - bitta narsani har xil formasi
// Logika har xil bo'lishi mumkin, vazifasi bir xil bo'ladi

// Overload - compile time - bir xil nomli methodlarni har xil versiyasi
// Overloading turlari : 
// Constructor overloading
// Method overloading

// Method overloadingga misol :
Console.WriteLine("Overload qilingan methodlar : ");

Console.WriteLine($"calculator.Add(10, 10) - {calculator.Add(10, 10)}");
Console.WriteLine($"calculator.Add(10.5D, 10.4D) - {calculator.Add(10.5D, 10.4D)}");
Console.WriteLine($"calculator.Add(\"textA\", \"textB\") - {calculator.Add("textA", "textB")}");

Console.WriteLine();

#endregion 

#region Polymorphism - Constructor overloading

// Constructor overloaddingga misol : 
Console.WriteLine("Overload qilingan konstruktorlar va \"this\" ni ishlatish : ");
Console.WriteLine();


Console.WriteLine("new User(\"John\", \"Doe\") bilan object yaratilganda :");
var userA = new User("John", "Doe");
Console.WriteLine();

Console.WriteLine("new User(\"John\", \"Doe\", \"Jones\") bilan object yaratilganda :");
var userB = new User("John", "Doe", "Jones");
Console.WriteLine();

Console.WriteLine("new User(\"John\", \"Doe\", \"Jones\", 32) bilan object yaratilganda :");
var userC = new User("John", "Doe", "Jones", 32);

Console.WriteLine();

Console.WriteLine($"User(\"John\", \"Doe\") bilan object yaratilganda user - {userA}");
Console.WriteLine($"new User(\"John\", \"Doe\", \"Jones\") bilan object yaratilganda user - {userB}");
Console.WriteLine($"new User(\"John\", \"Doe\", \"Jones\", 32) bilan object yaratilganda user - {userC}");

Console.WriteLine();

Console.WriteLine("Overload qilingan konstruktorlar va \"base\" ni ishlatish : ");
Console.WriteLine();

Console.WriteLine("new Interviewer(\"John\", \"Doe\") bilan object yaratilganda :");
var interviewerA = new Interviewer("John", "Doe");
Console.WriteLine();

Console.WriteLine("new Interviewer(\"John\", \"Doe\", \"Jones\") bilan object yaratilganda :");
var interviewerB = new Interviewer("John", "Doe", "Jones");
Console.WriteLine();

#endregion