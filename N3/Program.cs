// Concatenation
var firstName = "John";
var lastName = "Bob";
var fullNameA = firstName + lastName;
var fullNameB = string.Concat(firstName, lastName);

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
    "nemo hic numquam sit impedit g'ayrat aperiam nam non possimus officia quia unde cupiditate accusamus deleniti consequatur " +
    "alias quasi minima asperiores! Autem mollitia perferendis asperiores impedit ut obcaecati voluptatibus veniam voluptate? " +
    "Expedita quisquam unde blanditiis illum facere ex, g'ayrat qui laborum omnis accusamus sed. Numquam possimus eaque esse explicabo " +
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
var objectA = (object)12;
var objectB = (object)12;
Console.WriteLine($"objectA == objectB - {objectA == objectB}");
Console.WriteLine($"objectA.Equals(objectB) - {objectA.Equals(objectB)}");
Console.WriteLine($"object.Equals(objectA,objectB) - {object.Equals(objectA, objectB)}");
Console.WriteLine($"object.ReferenceEquals(objectA, objectB) - {object.ReferenceEquals(objectA, objectB)}");