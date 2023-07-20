using System.Collections;
using System.Numerics;

#region Pattern matching

Console.WriteLine("Pattern matching");

// Don't use convert or cast for type conversion
var value = (object)"false";

// The following code will have runtime exception
//var intValue = Convert.ToInt32(value);
//Console.WriteLine(intValue);

//Declarative Type Pattern Matching - is , as 
Console.WriteLine("Declarative pattern matching : ");

// Check and conversion in one
if (value is int resultIntValue)
{
    Console.WriteLine(resultIntValue);
}
else if (value is string stringValue)
{
    Console.WriteLine(stringValue);
}
Console.WriteLine();

// Relational Pattern Matching
Console.WriteLine("Relational pattern matching : ");

var grade = 80;
var gradeLevel = grade switch
{
    >= 90 => "Top",
    >= 80 and < 90 => "Good",
    >= 70 and < 80 => "Normal",
    _ => "Bad"
};
Console.WriteLine(gradeLevel);
Console.WriteLine();

#endregion

#region Unique value

// Unique values
Console.WriteLine("Generating unique values : ");

// Getting unique values from random values - wrong
// Issues - value is not unique 5 out of 10 times and using sequential value is bad
var random = new Random();
var uniqueValues = new List<int>();

for (int indexA = 0; indexA < 10;)
{
    var randomValue = random.Next(1, 20);

    if (uniqueValues.Count == 0)
        uniqueValues.Add(randomValue);

    for (int indexB = 0; indexB < uniqueValues.Count; indexB++)
    {
        if (uniqueValues[indexB] == randomValue)
        {
            Console.WriteLine($"Duplicate value while generating unique value - {randomValue}");
            break;
        }
        else
        {
            uniqueValues.Add(randomValue);
            indexA++;
            break;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Generated unique values from random values : ");
foreach (var uniqueValue in uniqueValues)
    Console.WriteLine(uniqueValue);

Console.WriteLine();


// Getting truly unique values
var guids = new Guid[]
{
    Guid.Parse("4743eb08-73e3-49e3-81cc-b4193ec8e87b"),
    Guid.Parse("03d3487c-64df-4d71-9620-a790b8c0e646"),
    Guid.Parse("daf6dda4-1e16-4e2e-a791-abbd64bcae5f"),
    Guid.Parse("df4fcb6a-41bd-40d4-8bee-0517f56e3c7b"),
    Guid.Parse("72d08cb1-5c56-49c6-8525-1fc1825ec738"),
    Guid.Parse("995735d7-9c39-4f3d-9368-e8813f443f34"),
    Guid.Parse("55d91fdc-f6b8-4b42-ae07-94165d45db77"),
    Guid.Parse("eb7d8631-ad61-45ac-b515-521e3d38bbf6"),
    Guid.Parse("8d990739-08f0-4797-9538-14f5a34db9eb"),
    Guid.Parse("9fda6511-542a-456d-b484-379dd8bebc49")
};

for (var indexA = 0; indexA < guids.Length - 1; indexA++)
    for (var indexB = indexA + 1; indexB < guids.Length; indexB++)
    {
        if (guids[indexA] == guids[indexB])
            Console.WriteLine($"Wow duplicate va  lue found : ");
    }

Console.WriteLine($"Guid.NewGuid() - {Guid.NewGuid()}");
Console.WriteLine($"Guid.Empty - {Guid.Empty}");
Console.WriteLine();

#endregion

#region Casting, Conversion and Parsing

//Casting and BigInteger
Console.WriteLine("Casting : ");

// Problem - need to calculate 10_000 * 10_000 * 10_000

// Implicit casting - from int to double
Console.WriteLine($"Implict casting  - {(double)10}");

// Explicit casting - from double to int
Console.WriteLine($"Explicit casting  - {(int)10.678D}");

// Boxing - from int to object
Console.WriteLine($"Boxing  - {(object)10}");

// Unboxing - from object to int
Console.WriteLine($"Unboxing - {(int)(object)10}");
Console.WriteLine();

// Version 1
// Try with  10_000 * 10_000 * 10_000
Console.WriteLine("Calculating using only int, enter 10000 x3 times and then exit");
var option = string.Empty;
var sumA = 1;
do
{
    if (int.TryParse(option, out var parsedValue))
        sumA *= parsedValue;

    Console.Write("Enter a number : ");
    option = Console.ReadLine();

} while (option != "exit");

Console.WriteLine($"Result using only int - {sumA}");
Console.WriteLine();

// Version 2
// Try with  10_000 * 10_000 * 10_000
Console.WriteLine("Calculating using only int, enter 10000 x3 times");
var sumIntB = 1;
var sumBigInt = new BigInteger(1);
var calculateWithBigSum = false;
do
{
    Console.Write("Enter a number : ");
    option = Console.ReadLine();

    if (!calculateWithBigSum && byte.TryParse(option, out var parsedValue))
        sumIntB = sumIntB * parsedValue;
    else if (BigInteger.TryParse(option, out var valueBig))
    {
        if (!calculateWithBigSum)
        {
            sumBigInt = sumIntB;
            calculateWithBigSum = true;
        }

        sumBigInt *= valueBig;
    }
} while (option != "exit");

Console.WriteLine($"Result only int and big Int - {(calculateWithBigSum ? sumBigInt : sumIntB)}");
Console.WriteLine();

// Conversion
var valueString = "false";
var valueBool = false;
var valueDouble = 0D;

// Don't use conversion if you know it may fail
//Console.WriteLine(Convert.ToInt32(valueString)); // will fail
Console.WriteLine($"Converting false to byte - {Convert.ToByte(valueBool)}");
Console.WriteLine($"Converting double to byte {Convert.ToByte(valueDouble)}");

// Parsing
Console.Write("Parsing false to byte - ");
if (int.TryParse("false", out var result))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("couldn't parse, but didn't throw exception too ))");
}
Console.WriteLine();

#endregion

#region Array and Collections

Console.WriteLine("Array and Collections");

// Simple array
var arrayValue = new int[10];

// ArrayList
// Add
// AddRange
// Remove
// RemoveRange
// Clear
var arrayList = new ArrayList();
arrayList.Add(10);
arrayList.Add("10");
arrayList.Add(10D);
arrayList.Add(10F);

// Lists

// Special methods : 
// Add
// AddRange
// Contains
// Insert
// Reverse
// Remove
// RemoveRange
// RemoveAt

var list = new List<int>();

list.Add(10);
list.AddRange(new int[] { 10, 20 });
list.Contains(1);
list.Insert(1, 10);
list.Reverse();
list.Remove(10);
list.RemoveRange(0, 2);
list.RemoveAt(0);

// Stack
// LIFO - Last In First Out

// Special methods : 
// Push
// Peek
// Pop

var stack = new Stack<int>();
stack.Push(10);
var peekValue = stack.Peek();
var popValue = stack.Pop();

// Queue
// FIFO - First In First Out

// Special methods : 
// Enqueue
// Dequeue
// Peek

Console.WriteLine("Queue operations");

var queue = new Queue<string>();
queue.Enqueue("John");
queue.Enqueue("G'ayrat");
queue.Enqueue("Teshavoy");
queue.Enqueue("Bob");
queue.Enqueue("G'ishmat");

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

// LinkedList

// Special methods : 
// Find
// FindLast
// AddFirst
// AddLast
// AddBefore
// AddAfter
// Remove
// RemoveFirst
// RemoveLast


var linkedList = new LinkedList<int>();

Console.WriteLine(linkedList.Find(10));

linkedList.Find(10);
linkedList.FindLast(10);

linkedList.AddFirst(5);
linkedList.AddLast(10);

linkedList.AddBefore(linkedList.Find(10), 20);
linkedList.AddAfter(linkedList.Find(10), 20);

linkedList.Remove(5);
linkedList.RemoveFirst();
linkedList.RemoveLast();

// Dictionary

var dictionary =
    new Dictionary<string, User>();

dictionary.Add("John", new User());
dictionary.Add("john007", new User());

public class User
{
    public string FirstName { get; set; }
}

#endregion
