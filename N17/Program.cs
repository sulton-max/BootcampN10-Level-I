using System.Runtime.InteropServices;
using N17.CopyCtor;
using N17.DefaultCtor;
using N17.NormalClass;
using N17.ParameterizedCtor;
using N17.SealedClass;

#region Class Types

//MessageConstants.UserToken = "This won't work"; // invalid - 

// Normal class
var user = new Job
{
    Name = "Streamer"
};

Console.WriteLine(user.Name);

// Static class
Console.WriteLine("Hello {{User}}, {{App}}"
    .Replace(MessageConstants.UserToken, "G`isthmat")
    .Replace(MessageConstants.AppToken, "Some App"));

// static - data yoki behiovrni objectga bo`g`liq bo'lmagan holatda murojaatga qilishga ruxsat beradi
// const - primitive va objectga bo`g`liq bo'lmagan ma`lumotlar uchun
// static readonly - complex va objectga bo`g`liq bo'lmagan ma`lumotlar uchun

//var messageConstants = new MessageConstants(); // invalid va ma'nosi yo'q

// Abstract class
//var animal = new Animal(); // invalid va ma'nosi yo'q

var bird = new Bird();
Console.WriteLine(bird.GetSound());

// Sealed class
var circle = new Circle(10);
Console.WriteLine(circle.CalculateArea());

#endregion

#region

// Default Constructor
var passwordGenerator = new PasswordGenerator();

// Parameterized Constructor - ma'lumotlarsiz tasavvur qilib bo'lmaydigan tiplar uchun
var specialUser = new User("John");

// Copy Constructor
var engine = new Engine("nimadir engine");

var bmwA = new Bmw("M5", engine);
var bmwB = new Bmw(bmwA);

Console.WriteLine(object.ReferenceEquals(bmwA.Engine, engine));
Console.WriteLine(object.ReferenceEquals(bmwA.Engine, bmwB.Engine));

#endregion