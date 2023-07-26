// Overriding System.Object behavior

// Equals - tengligini tekshirish
// GetHashCode - minimal ko'rinishda solishtirish, reference ni hash code qilib qaytaradi
// GetType - object tipini olish
// ToString - objectni stringga aylantirish

#region Equals ni logikasini o'zgartirish

// Equals logikasi
// Reference tiplar uchun - address bo'yicha
// Value tiplar uchun - qiymat bo'yicha

using System.Text.RegularExpressions;

var userA = new User
{
    FirstName = "John",
    LastName = "Johnson",
    Age = 32
};

var car = new Car
{
    Age = 32
};

Console.WriteLine($"User va Carni yoshi bo'yicha tenlashtirish - userA.Equals(car) - {userA.Equals(car)}");

#endregion

#region Hash Code ni logikasini o'zgartirish

// GetHashCode logikasi
// Reference tiplari uchun - addressdan kelib chiqadi
// Value tiplar uchun - qiymatdan kelib chiqadi

// Solishtirish usullari 
// #1 - reference bo'yicha
// #2 - har bitta data ( field, property ) solishtirishi
// #3 - hashcode

// Hashcode ga misol
// List<User> - hamma o'quvchilar          
// List<User> - bugun kelgan o'quvchilar    

// 12345678  - 4 - guruhda avvaldan bor o'quvchi Idsi
// 12349678  - 9 - guruhga yangi kelgan o'quvchi Idsi
// Bunda guruhda o'quvchilar bir xil ekanlgini solishtirish uchun tepadagi hash code larni solishtirish kifoya, 
// o'quvchilar ismi, sharifi va hk. ni solishtirish shartmas

var userB = new User
{
    FirstName = "John",
    LastName = "Johnson",
    Age = 32
};

var userC = new User
{
    FirstName = "John",
    LastName = "Johnson",
    Age = 32
};

//var car = new Car();

Console.WriteLine($"userB.Equals(userC) - {userB.Equals(userC)}");
Console.WriteLine($"userC.GetHashCode() - {userC.GetHashCode()}");
Console.WriteLine($"userB.GetHashCode() - {userB.GetHashCode()}");
Console.WriteLine($"userB.GetHashCode() == userC.GetHashCode() - {userB.GetHashCode() == userC.GetHashCode()}");

#endregion

#region ToString ni logikasini o'zgartirish

var userD = new User
{
    FirstName = "John",
    LastName = "Johnson",
    Age = 32
};

// eski usul
//Console.WriteLine($"Firstname - {userD.FirstName} LastName - {userD.LastName} Age - {userD.Age}");

// oddiy va yangi usul
Console.WriteLine(userD);

#endregion

#region Class members - Property and Field

// Property
var animal = new Animal();
animal.Name = "6789"; // Format exception

public class Animal
{
    // Data

    // Field - ma'lumot saqlaydigan member
    // public string Name;

    // Auto Property - { get; set } qilib e'lon qiligan property - tagida ishlaydigan field automatic generate bo'ladi
    // Property - get va set operatsiyalari uchun logikasi bor bo'lgan member

    public string _name;

    // eski usul
    // public void SetName(string value)
    // {
    //     _name = value;
    // }

    // public string GetName()
    // {
    //     return _name;
    // }


    //public string FirstName;

    public string _firstName;

    public string FirstName { get => _firstName; set => _firstName = value; }

    public string LastName;
    public string MiddleName;
    //public string FullName

    // get 
    // set 

    public string FullName
    {
        get => $"{FirstName} {LastName} {MiddleName}";
    }

    //public string GetFullName()
    //{
    //    //return FirstName + " " + LastName + " " + MiddleName;
    //    //return $"{FirstName} {LastName} {MiddleName}";
    //    //return string.Join(' ', new[] {FirstName, LastName, MiddleName});
    //}

    public string Name
    {
        get 
        { 
            return _name; 
        }
        set
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]+$"))
                _name = value;
            else
                throw new FormatException("Animal nomi sondan iborat G`ishtmat");
        }
    }

    // Behavior
}

#endregion

public class Car
{
    public int Age;
}

public class User
{
    public string FirstName;
    public string LastName;
    public int Age;

    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return this.GetHashCode() == user.GetHashCode();
        else if (obj is Car car)
            return this.Age == car.Age;
        else if (obj is int age)
            return this.Age == age;

        return false;
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode()
               + LastName.GetHashCode()
               + Age.GetHashCode();
    }

    public override string ToString()
    {
        return $"Firstname - {FirstName} LastName - {LastName} Age - {Age}";
    }
}