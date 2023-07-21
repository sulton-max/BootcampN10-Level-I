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


#endregion