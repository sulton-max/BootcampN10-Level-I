namespace N13;

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