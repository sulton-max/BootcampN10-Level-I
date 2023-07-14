// Concatenation
using System.Runtime.InteropServices;

#region Concatenation

var firstName = "John";
var lastName = "Bob";
var fullNameA = firstName + lastName;
var fullNameB = string.Concat(firstName, lastName);

#endregion 

// Escape characters
var comment = "U aytdiki :\"Ispeak C#\"";
var charValue = '\'';
var textValue = "\v C# \v .NET";
Console.WriteLine(textValue);
Console.WriteLine();

var greeting = "Hi John \nWelcome to our portal!";
Console.WriteLine(greeting);
Console.WriteLine();

// Verbatim string
// Verbatim string escape character maxsus vazifasinidan ozod qiladi
var filePath = @"D:\Projects\Repositories\Company\NajotTalim\Groups\Bootcamp N10\BootcampN10-Level-I\N3\Program.cs";

// Interpolation and Formatting
var firstNameB = "G`ayrat";
var appName = "Teshavoy App";
var url = "www.example.com";

// Interpolation
// Interpolation - shablon kod ichida bo'lsa ishlatiladi
var greetingB = $"Hello {firstName + lastName}, Welcome to our {1}. Enter this {2} to verify your account";
Console.WriteLine(greetingB);
Console.WriteLine();


// Formatting
// Formatting - shablon koddan tashqari bo'lsa ishlatiladi
var greetingA = "Hello {0}, Welcome to our {1}. Enter this {2} to verify your account";
var formattedGreetingA = string.Format(greetingA, firstNameB + lastName, appName, url);

Console.WriteLine(formattedGreetingA);
Console.WriteLine(greetingA, firstNameB, appName, url);

// Length, indexing va substring
// Length
Console.WriteLine($"formattedGreetingA uzunligi {formattedGreetingA.Length}");
Console.WriteLine();


// Index
Console.WriteLine($"Element at index 60 : {formattedGreetingA[60]}");
Console.WriteLine();

// Substring
Console.WriteLine($"Substring from index {10} wizth length {10}: {formattedGreetingA.Substring(10, 10)}");
Console.WriteLine();

// Splitting
var text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eum assumenda laborum debitis maiores, " +
    "nemo hic numquam sit impedit g'ayrat aperiam nam non possimus officia quia unde cupiditate deleniti consequatur " +
    "alias quasi minima asperiores! Autem mollitia perferendis asperiores impedit ut obcaecati voluptatibus veniam voluptate? " +
    "Expedita quisquam unde blanditiiS illum facere ex, g'ayrat qui laborum omnis accusamus sed. Numquam possimus eaque esse explicabo " +
    "repudiandae et, suscipit quasi dolore saepe voluptatum rem, dignissimos vero dolorum molestiae. Amet cumque sequi dicta in " +
    "voluptates architecto ipsum, g'ayrat obcaecati quos magnam inventore hic nostrum quod esse facere beatae praesentium vitae tempora " +
    "maxime perspiciatis veritatis sed est neque aut.\r\n";

var sentences = text.Split('.', '?', '!');
foreach (var sentence in sentences)
    Console.WriteLine(sentence);
Console.WriteLine();

var words = text.Split(' ');
foreach (var word in words)
    Console.WriteLine(word);
Console.WriteLine();
Console.WriteLine();

var firstNameOccurance = text.Split("g'ayrat");
foreach (var sentence in firstNameOccurance)
    Console.WriteLine(sentence);

Console.WriteLine($"The time to read this article : {words.Length / 100F}");
Console.WriteLine();

// Joining
var joinedString = string.Join(' ', words);
Console.WriteLine(joinedString);
Console.WriteLine();

// Cases - Lower, Upper
// camelCase
// PascalCase
// snake_case
// kebab-case

// Capitalizing
var unformattedFirstname = "fIrDaVs";
var capitalizedFirstName = string.Concat(unformattedFirstname.Substring(0, 1)
    .ToUpper(), unformattedFirstname.Substring(1).ToLower());

Console.WriteLine(capitalizedFirstName);
Console.WriteLine();

// Comparison and Equality

// ! Only for objects
// == - compares by reference
// instance.Equals - by value
// class.Equals - by value
// class.ReferenceEquals - by reference

var objectA = (object)12;
var objectB = (object)12;
Console.WriteLine("Object comparison : ");
Console.WriteLine($"objectA == objectB - {objectA == objectB}");
Console.WriteLine($"objectA.Equals(objectB) - {objectA.Equals(objectB)}");
Console.WriteLine($"object.Equals(objectA,objectB) - {object.Equals(objectA, objectB)}");
Console.WriteLine($"object.ReferenceEquals(objectA, objectB) - {object.ReferenceEquals(objectA, objectB)}");
Console.WriteLine();

// ! Only for objects
// == - compares by reference
// instance.Equals - by value
// class.Equals - by value
// class.ReferenceEquals - by reference

// #1 If string is predefined, and equal they will allocate the same address
// #2 If string is undefined, and equal they will allocate the different address
var test = new string[10]
{
    "test",
    "test",
    "test",
    "test",
    "test",
    "test",
    "test",
    "test",
    "test",
    "test"
};

var random = new Random();
for( var index = 0; index < test.Length; index++)
{
    Console.WriteLine();

    //GCHandle handleC = GCHandle.Alloc(test[index], GCHandleType.Pinned);
    //IntPtr pointerC = handleC.AddrOfPinnedObject();
    //Console.WriteLine(pointerC.ToString());

    //test[index] += random.Next(1, 2);
    //Console.WriteLine("After change");

    //GCHandle handleA = GCHandle.Alloc(test[index], GCHandleType.Pinned);
    //IntPtr pointerA = handleA.AddrOfPinnedObject();
    //Console.WriteLine(pointerA.ToString());

    //test[index] += random.Next(1, 2);
    //Console.WriteLine("After change 2");

    //GCHandle handleD = GCHandle.Alloc(test[index], GCHandleType.Pinned);
    //IntPtr pointerD = handleD.AddrOfPinnedObject();
    //Console.WriteLine(pointerD.ToString());

    Console.WriteLine();
}

// ! Only for objects
// == - compares by value
// instance.Equals - by value
// class.Equals - by value
// class.ReferenceEquals - by reference

var stringA = "text";
var stringB = "text";
Console.WriteLine("String comparison : ");
Console.WriteLine($"stringA == stringA - {stringA == stringB}");
Console.WriteLine($"stringA.Equals(stringA) - {stringA.Equals(stringB)}");
Console.WriteLine($"string.Equals(stringA,stringA) - {string.Equals(stringA, stringB)}");
Console.WriteLine($"string.ReferenceEquals(stringA, stringA) - {string.ReferenceEquals(stringA, stringB)}");
Console.WriteLine();

stringB = "Text";
Console.WriteLine("After change : ");
Console.WriteLine($"stringA == stringA - {stringA == stringB}");
Console.WriteLine($"stringA.Equals(stringA) - {stringA.Equals(stringB)}");
Console.WriteLine($"string.Equals(stringA,stringA) - {string.Equals(stringA, stringB)}");
Console.WriteLine($"string.ReferenceEquals(stringA, stringA) - {string.ReferenceEquals(stringA, stringB)}");

//GCHandle handleB = GCHandle.Alloc(stringA, GCHandleType.Pinned);
//IntPtr pointerB = handleB.AddrOfPinnedObject();
//Console.WriteLine(pointerB.ToString());

//GCHandle handleC = GCHandle.Alloc(stringB, GCHandleType.Pinned);
//IntPtr pointerC = handleC.AddrOfPinnedObject();
//Console.WriteLine(pointerC.ToString());

// Example of string comparison
//Console.Write("Enter your firstname : ");
//var input = Console.ReadLine();
//var formattedInput = string.Concat(input.Substring(0, 1)
//    .ToUpper(), input.Substring(1).ToLower());

//Console.WriteLine($"is correct : {input == formattedInput}");

// Equality
var firstName1 = "john";
var firstName2 = "jOhN";
Console.WriteLine();
Console.WriteLine($"firstName1 equals firstName2 - {firstName1.Equals(firstName2, StringComparison.OrdinalIgnoreCase)}");

// Searching
Console.WriteLine($"text contains saepe - {text.Contains("saepE", StringComparison.OrdinalIgnoreCase)}");
var wordIndexA = text.IndexOf("blanditiiS", StringComparison.OrdinalIgnoreCase);
var wordIndexB = text.IndexOf("accusamus", StringComparison.OrdinalIgnoreCase);
Console.WriteLine(text.Substring(wordIndexA + "blanditiiS".Length, wordIndexB - wordIndexA));

// Replacing
var userNameToken = "{{User}}";
var urlToken = "{{Url}}";
var appNameToken = "{{AppName}}";
var passwordToken = "{{PasswordToken}}";

var notification = "Hello {{User}}, Dear User, Welcome to our {{Url}}. Enter this {{AppName}} to verify your account";
var formattedNotification = notification
    .Replace(userNameToken, "G'ayrat")
    .Replace(urlToken, "www.example.com")
    .Replace(appNameToken, "Dev Blogs")
    .Replace(passwordToken, "556789");

Console.WriteLine(formattedNotification);

// Trim and Padding
Console.WriteLine();
Console.WriteLine("Trimming : ");
var exampleForTrim = "     text  text  **";

Console.WriteLine($"Trim default - {exampleForTrim.Trim()} and lenght - {exampleForTrim.Trim().Length}");
Console.WriteLine($"Trim default - {exampleForTrim.Trim('*', ' ')} and lenght - {exampleForTrim.Trim('*', ' ').Length}");

// Padding
var exampleForPadding = "text";
Console.WriteLine($"Padding default - {exampleForPadding.PadLeft(10)} and lenght - {exampleForPadding.PadLeft(10)}");
Console.WriteLine($"Padding default - {exampleForPadding.PadRight(10, '*')} and lenght - {exampleForPadding.PadRight(10)}");