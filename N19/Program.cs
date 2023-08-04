using N19;

// In parameter - parameter qiymati o'zgarmasligi uchun

// In - reference tiplar uchun - original qiymat o'zgmasligi uchun
// In - value tiplar uchun - method ichida o'sha parameter qiymati o'zgarmasligi uchun
Console.WriteLine($"In parameter : ");
var array = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine($"Sum - {StaticType.Sum(array)}");
Console.WriteLine();

// Out parameter - qiymati method ichkarisidan beriladigan parameter
// 2 chi qiymat qaytishi uchun

Console.WriteLine($"Out parameter : ");
if (StaticType.IsValidEmailAddress("           @test@gmail.com", out var fixedEmailAddress))
    Console.WriteLine($"fixedEmailAddress - {fixedEmailAddress}");
else
    Console.WriteLine($"fixedEmailAddress - {fixedEmailAddress}");
Console.WriteLine();

// Immutable - qiymati o'zgarmas tiplar

// Ref - original qiymatni o'zgarishini ta'minlash
// Ref - value tiplar uchun - original o'zgaruvchidagi qiymatni o'zgartiradi 
// Ref - reference tiplar uchun - original o'zgaruvchidagi addressni o'zgartiradi

Console.WriteLine("Ref parameter : ");
Console.WriteLine("Ref parametersiz :");

var template = "Hello {{User}}";
StaticType.ToMessage(template);
Console.WriteLine($"template - {template}");
Console.WriteLine();

Console.WriteLine("Ref parameter bilan :");
StaticType.ToMessageB(ref template);
Console.WriteLine($"template - {template}");
Console.WriteLine();

var balance = 10000;
if (StaticType.WithdrawMoney(ref balance, 5000))
    Console.WriteLine($"balance - {balance}");
else 
    Console.WriteLine($"balance - {balance}");

Console.WriteLine();

// Params - bir yoki nechta parameter yoki array bilan chaqirish imkonini beradi
Console.WriteLine($"Params parameter : ");

var box1 = new Drink("Cola", 3);
var box2 = new Drink("Cola", 3);
var box3 = new Drink("Cola", 3);
var boxAll = new Drink[]
{
    new Drink("Fanta", 2),
    new Drink("Sprite", 2),
    new Drink("Mountain Dew", 3),
    new Drink("Fanta", 2),
    new Drink("Cola", 3),
};

Console.WriteLine($"Bitta parameter bilan - {StaticType.CalculatePrice(box1)}");
Console.WriteLine($"Bit nechta parameter bilan - {StaticType.CalculatePrice(box1, box2, box3)}");
Console.WriteLine($"Array bilan - {StaticType.CalculatePrice(boxAll)}");
Console.WriteLine();

// Optional - ixtiyority parameterlar
// Named - methodni chaqirganda argumentlarni parameter nomi bilan belgilash, bunda bitta argument uchun nom ishlatilsa, hammasi uchun ishlatish shart bo'ladi
Console.WriteLine("Optional va Named parameterlar : ");

Console.WriteLine(StaticType.CalculateCredit(months: 12, principal: 2000));
Console.WriteLine(StaticType.CalculateCredit(months: 12, principal: 2000, interest: 18));