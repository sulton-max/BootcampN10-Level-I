// Overriding System.Object behavior

// Equals - tengligini tekshirish
// GetHashCode - minimal ko'rinishda solishtirish, reference ni hash code qilib qaytaradi
// GetType - 
// ToString - 

#region Equals 

// Equals logikasi
// Reference tiplar uchun - address bo'yicha
// Value tiplar uchun - qiymat bo'yicha

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

Console.WriteLine(userA.Equals(car));

#endregion 

#region 

// GetHashCode logikasi
// Reference tiplari uchun - addressdan kelib chiqadi
// Value tiplar uchun - qiymatdan kelib chiqadi

// Solishtirish usullari 
// #1 - reference bo'yicha
// #2 - har bitta data ( field, property ) solishtirishi
// #3 - hashcode

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

Console.WriteLine(userB.Equals(userC));
Console.WriteLine(userC.GetHashCode());
Console.WriteLine(userB.GetHashCode());
Console.WriteLine(userB.GetHashCode() == userC.GetHashCode());

//Console.WriteLine(userB.GetHashCode());

//user.

// List<User> - hamma o'quvchilar          - 
// List<User> - bugun kelgan o'quvchilar   - 

// 12345678
// 12349678

#endregion

#region Class members

// Constructor

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
}