// Nomlash
// o'zgaruvchi - camelCase
// tip - PascalCase
// fayl nomi - PascalCase
// namespace - PascalCase
// project nomi - PascalCase
// solution nomi - PascalCase
// method - PascalCase
// field - private - _camelCase, public - PascalCase        
// method - PascalCase

// firstName, lastName, age o'zgaruvchilarini e'lon qilish
var firstName = default(string);
var lastName = default(string);
var age = default(byte);

// shu o'zgaruvchilarga qiymatlarini foydalanuvchidan so'rash
Console.WriteLine("Enter you first name");
firstName = Console.ReadLine();

Console.WriteLine("Enter you last name");
lastName = Console.ReadLine();

Console.WriteLine("Enter you age");
age = byte.Parse(Console.ReadLine());

// User tipidan object olish va qiymatlarini tenglash
var user = new User
{
    FirstName = firstName,
    LastName = lastName,
    Age = age
};

// User tipi fieldlarini ekranga chiqaring
Console.WriteLine($"Firstname : { user.FirstName}");
Console.WriteLine($"LastName : { user.LastName}");
Console.WriteLine($"Age : { user.Age}");

// foydalanuvchi uchun User tipini yaratish
public class User
{
    // User tipida FirstName, LastName, Age fieldlarni bo'lsin
    public string FirstName;
    public string LastName;
    public byte Age;
}