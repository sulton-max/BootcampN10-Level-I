#region Branching

Console.WriteLine("IsNullOrEmpty : ");
Console.WriteLine($"string.IsNullOrEmpty(null) - {string.IsNullOrEmpty(null)}");
Console.WriteLine($"string.IsNullOrEmpty(\"\") - {string.IsNullOrEmpty("")}");
Console.WriteLine($"string.IsNullOrEmpty(string.Empty) - {string.IsNullOrEmpty(string.Empty)}");
Console.WriteLine($"string.IsNullOrEmpty(\" \") - {string.IsNullOrEmpty(" ")}");
Console.WriteLine($"string.IsNullOrEmpty(\"text\") - {string.IsNullOrEmpty("text")}");

Console.WriteLine("\n IsNullOrWhiteSpace : ");
Console.WriteLine($"string.IsNullOrWhiteSpace(null) - {string.IsNullOrWhiteSpace(null)}");
Console.WriteLine($"string.IsNullOrWhiteSpace(\"\") - {string.IsNullOrWhiteSpace("")}");
Console.WriteLine($"string.IsNullOrWhiteSpace(string.Empty) - {string.IsNullOrWhiteSpace(string.Empty)}");
Console.WriteLine($"string.IsNullOrWhiteSpace(\" \") - {string.IsNullOrWhiteSpace(" ")}");
Console.WriteLine($"string.IsNullOrWhiteSpace(\"text\") - {string.IsNullOrWhiteSpace("text")}");


// Branching with If
Console.WriteLine();
Console.WriteLine("Branching with If");
Console.Write("Enter your firstname : ");
var userName = Console.ReadLine();
Console.Write("Hello ");

if (!string.IsNullOrWhiteSpace(userName))
{
    Console.Write(" " + userName + " ");
}

Console.WriteLine("Welcome");
Console.WriteLine();


// Branching If-Else
Console.WriteLine("Branching with If-Else");

Console.Write("Enter your email address : ");
var emailAddress = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(emailAddress))
{
    Console.WriteLine($"Great! Now check your inbox for {emailAddress}");
}
else
{
    Console.Write("Incorrect email address");
}
Console.WriteLine();

// Branching with Else-If
Console.Write("Enter your age : ");
var age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Uzr, siz kichkinasiz");
}
else if (age > 150)
{
    Console.WriteLine("Uzr, yana bir bor tekshirib ko'ring");
}
else
{
    Console.WriteLine("Saytga xush kelibsiz");
}
Console.WriteLine();

// Nested If
Console.Write("Enter your email address : ");
var emailAddressB = Console.ReadLine();

// Minimmum length email domen - a@io
if (string.IsNullOrWhiteSpace(emailAddressB))
{
    if (emailAddressB.Length > 5)
    {
        if (emailAddressB.Contains('@'))
            Console.WriteLine("Email is valid, check your inbox");
        else
            Console.WriteLine("Email should contain @");
    }
    else
        Console.WriteLine("Email must be longer than 4 characters");
}
else
    Console.WriteLine("Email is null");
Console.WriteLine();


// Branching with Switch
Console.Write("Enter week day : ");
var weekDay = int.Parse(Console.ReadLine());

// Tarjimalar jadvalda qanday saqlanishi
// DayNameInEng      Name           Lang
// Monday            Dushanba       uz
// Tuesday           Dushanba       uz
// Wednesday         Dushanba       uz

switch (weekDay)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday"); break;
    case 7: Console.WriteLine("Sunday"); break;
    default: Console.WriteLine("Invalid week day"); break;
}

// Branching Switch Expression
var weekDayInString = weekDay switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Invalid week day"
};
Console.WriteLine();

#endregion

#region Looping

//Looping with Do
// do {} while(true) - infinite loop
Console.WriteLine("Looping with Do");
var option = string.Empty;
do
{
    Console.Write("Enter command : ");
    option = Console.ReadLine();
} while (option != "exit");
Console.WriteLine();

// Looping with While
// while(true) { } - infinite loop
Console.WriteLine("Looping with While");
var now = DateTime.Now.AddDays(17);
var result = now.AddDays(1);
while (result.Day == 1)
{
    Console.WriteLine("Prepare for exam, bruh");
}

//Looping with For
//for ( ; ; ) -infinite loop
var text = "The word \"word\" is a word. It is a word that is used to represent other words. Words are used " +
    "to communicate with other people. Words are used to write essays. Essays are written with words. Words are " +
    "important. Words Words Words Words are used to express ideas. Ideas are important. Ideas are used to create things. Things are" +
    " important. Things are made with words. Words are the foundation of everything.";

var wordsCount = 0;
var words = text.Split(' ', ',');
for (var index = 0; index < words.Length; index++) 
{
    wordsCount = words[index].Contains("word", StringComparison.OrdinalIgnoreCase)
        ? wordsCount + 1
        : wordsCount;
}

//Console.WriteLine(wordsCount);
Console.WriteLine(words.Length / 5 < wordsCount);

// Looping with ForEach
var options = new string[]
{
    "registration",
    "login",
    "exit"
};

foreach (var command in options)
    Console.WriteLine(command);

#endregion

#region Pattern Matching

#endregion