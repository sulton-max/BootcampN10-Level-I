#region Nested Control Structures 

//var a = 10;
//var b = 20;
//var c = 30;

// Version 1
//if(a > b)
//{
//    if(a > c)
//    {

//    }
//}

// Version 2
//if (a > b && a > c)
//{
//}

//public static class Test
//{
//    public static void SendEmail(string email)
//    {
//        // Version 1
//        //if (!string.IsNullOrWhiteSpace(email))
//        //{
//        //    if (email.Length > 5)
//        //    {
//        //        if (email.Contains("@"))
//        //        {
//        //            // Sending email
//        //        }
//        //    }
//        //}

//        // Version 2
//        if (string.IsNullOrWhiteSpace(email))
//            return;

//        if (email.Length > 5 && email.Contains("@"))
//            // Sending email
//    }
//}

#endregion


#region Error Handling

// Shablon
//try
//{
//    // Asosiy
//}
//catch (Exception exception)
//{
//    // Istisno bo'lgan holatda
//    throw;
//}
//finally
//{
//    // Resurslarni tozalash
//}

// Error - xatolik
// Exception - istisno klassi
// Exception Order - from detailed to abstract
// Throwing Exception - exception larni o'zimiz yaratish
// Throw qilasiz - qachonki detail qo'shmoqchi bo'lsangiz

//using System;

//var objectValue = default(object);
//try
//{
//    //Console.WriteLine(objectValue.ToString());

//    if (objectValue is null)
//        throw new NullReferenceException($"{nameof(objectValue)} is null");
//}
//catch (NullReferenceException nullReferenceException)
//{
//    Console.WriteLine(nullReferenceException);
//}
//catch (Exception exception)
//{
//    Console.WriteLine(exception);
//}
//finally
//{
//    Console.WriteLine("Ish tugadi");
//}

#endregion

#region OOP Intro

// Data Structure - ma'lumot strukturasi - class, struct, record, interface, enum
// Type - Exact Data Structure - aniq ma'lumot strukturasi
// Instance - object - bitta example

//var obj = new class
using System.Runtime.InteropServices;

var user = new User("John");

// Roles - Model and Service

var terminal = new AirportTerminal();

terminal.Add(new User("John"));
terminal.Add(new User("Bob"));
terminal.Add(new User("G'ayrat"));

terminal.Display();

var test = new Test("testa", "testb");

GCHandle handleA = GCHandle.Alloc(test.TestA, GCHandleType.Pinned);
IntPtr pointerA = handleA.AddrOfPinnedObject();
Console.WriteLine(pointerA.ToString());

GCHandle handleB = GCHandle.Alloc(test.TestB, GCHandleType.Pinned);
IntPtr pointerB = handleB.AddrOfPinnedObject();
Console.WriteLine(pointerB.ToString());

// Service
public class AirportTerminal
{
    // Member - data, behavior

    // Data - ma'lumotlar
    // Field - maydon
    public Queue<User> _users = new Queue<User>();

    // Behavior - hatti-harakati
    // Method - metod
    // Parameter - 
    // Argument - 
    // Return Type - 
    // Body - 
    // Name - 
    // void - hech nima qaytarmaydigan
    public void Add(User user)
    {
        _users.Enqueue(user);
    }

    public void Display()
    {
        foreach (var user in _users)
            Console.WriteLine(user.FirstName);
    }
}

// Model
public class User
{
    public User(string firstName)
    {
        FirstName = firstName;
    }

    public string FirstName { get; set; }
}

public class Test
{
    public Test(string testA, string testB)
    {
        TestA = testA;
        TestB = testB;
    }

    public string TestB { get; set; }
    public string TestA { get; set; }
}



#endregion