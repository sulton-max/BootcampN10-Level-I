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




#endregion