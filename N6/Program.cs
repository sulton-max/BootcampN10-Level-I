#region Operators 

//Console.WriteLine("Arithmetic operatorlar : ");
//// Arithmetic operatorlar - arifmetik

//// Unary 

//// Increment
//var forIncrement = 1;

//// Post Increment
////Console.WriteLine(forIncrement++);

//// Pre Increment
////Console.WriteLine(++forIncrement);

//// Decrement

//// Post Decrement
////Console.WriteLine(forIncrement--);

//// Pre Decrement
////Console.WriteLine(--forIncrement);

//// Minus
////--forIncrement;
////--forIncrement;
////--forIncrement;
////Console.WriteLine(-forIncrement);
////Console.WriteLine(forIncrement);

//// Binary
//var a = 10 + 10;
//var b = 10 - 10;
//var c = 10 * 10;
//var d = 11F / 10;
//var e = 10 % 10;

//// Assignment operatorlar - tenglash
//int f, h, g;
//f = h = g = 10;
//Console.WriteLine(f);
//Console.WriteLine(h);
//Console.WriteLine(g);

//// Operator with assignment
//f += 10 + h;
//f -= 10;
//f *= 10;
//f /= 10;
//f %= 10;

//// Boolean operators - mantiqiy

//// !
//Console.WriteLine(!true);

//// &&
//Console.WriteLine(true && false);

//// ||
//Console.WriteLine(true || false);

//// ^
//Console.WriteLine(true ^ false);

//// | 
//Console.WriteLine(Convert.ToString(0b_101 | 0b_110, toBase: 2));

//// &
//Console.WriteLine(Convert.ToString(0b_101 & 0b_110, toBase: 2));

// ~
//Console.WriteLine(Convert.ToString(~0b_101, toBase: 2));

// 0101 | - bit uchun
// 1010
// 1111

// 0101 & - bit uchun
// 1010 
// 0000

// ^ - XOR - bit uchun, True va True - false
// 0011 &
// 1010 
// 1101

// Comparison operators - solishtirish

// == 
//Console.WriteLine(10 == 10);

//// != 
//Console.WriteLine(10 != 10);

//// >
//Console.WriteLine(10 > 10);

//// >= 
//Console.WriteLine(10 >= 10);

//// <
//Console.WriteLine(10 < 10);

//// <= 
//Console.WriteLine(10 <= 10);

// Bitwise operatorlar
//Console.WriteLine(Convert.ToString(0b_1110101 >> 2, toBase:2));
//Console.WriteLine(Convert.ToString(0b_1110101 << 2, toBase:2));

//Console.WriteLine(Convert.ToString(10, toBase:2));

// Operators precedence - operatorlar prioriteti

// Operator associativity - operatorlar bajarilish formasi

#endregion

#region Array operations

using System.Runtime.InteropServices;
using System;

var friends = new string[]
{
    "John",
    "Bob",
    "G'ayrat",
    "Timmy"
};

// Accessing elements
//Console.WriteLine(friends[1]);

// Modifying elements
//Console.WriteLine(friends[3] = "Teshavoy");
//Console.WriteLine(friends[3] = Console.ReadLine());

// Length
//Console.WriteLine(friends.Length);

// Iterating - for, foreach, do, while
var maxLengthIndex = 0;
for (var index = 0; index < friends.Length; index++)
{
    maxLengthIndex = friends[maxLengthIndex].Length > friends[index].Length
        ? maxLengthIndex
        : index;
}

//Console.WriteLine($"Longest name : {friends[maxLengthIndex]} " +
//    $"and it's length - {friends[maxLengthIndex].Length} " +
//    $"and its index - {maxLengthIndex}");

// Sorting - Ascending - o'suvchi
var tempString = string.Empty;
for (var indexA = 0; indexA < friends.Length - 1; indexA++)
    for (var indexB = indexA + 1; indexB < friends.Length; indexB++)
        if (friends[indexA].Length > friends[indexB].Length)
        {
            tempString = friends[indexA];
            friends[indexA] = friends[indexB];
            friends[indexB] = tempString;
        }

//Console.WriteLine("Sort ascending : ");
//foreach (var friend in friends)
//    Console.WriteLine(friend);

// Sorting - Descending - kamayuvchi
for (var indexA = 0; indexA < friends.Length - 1; indexA++)
    for (var indexB = indexA + 1; indexB < friends.Length; indexB++)
        if (friends[indexA].Length < friends[indexB].Length)
        {
            tempString = friends[indexA];
            friends[indexA] = friends[indexB];
            friends[indexB] = tempString;
        }

//Console.WriteLine();
//Console.WriteLine("Sort descending : ");
//foreach (var friend in friends)
//    Console.WriteLine(friend);

// Searching - elementlarni qidirish

// Adding elements - mumkinmas

// Removing elements - mumkinmas

// Copying 
// Shallow Copy - value type
// Deep Copy - to'liq

var friendsCopy = new string[friends.Length];
friends.CopyTo(friendsCopy, 0);
friends.CopyTo(friendsCopy, 0);

//foreach (var friend in friendsCopy)
//    Console.WriteLine(friend);

//GCHandle handleA = GCHandle.Alloc(friends[0], GCHandleType.Pinned);
//IntPtr pointerA = handleA.AddrOfPinnedObject();
//Console.WriteLine(pointerA.ToString());

//GCHandle handleB = GCHandle.Alloc(friendsCopy[0], GCHandleType.Pinned);
//IntPtr pointerB = handleA.AddrOfPinnedObject();
//Console.WriteLine(pointerA.ToString());

// Equality - elementlarni bo'yicha tekshirish


// Resize - kattaligini o'zgartirish
//GCHandle handleA = GCHandle.Alloc(friends[0], GCHandleType.Pinned);
//IntPtr pointerA = handleA.AddrOfPinnedObject();
//Console.WriteLine(pointerA.ToString());

Array.Resize(ref friends, friends.Length + 5);

//foreach (var friend in friendsCopy)
//Console.WriteLine(friends[6]);

//GCHandle handleB = GCHandle.Alloc(friends[0], GCHandleType.Pinned);
//IntPtr pointerB = handleA.AddrOfPinnedObject();
//Console.WriteLine(pointerA.ToString());

//var test = new DateTime(2000, 4, 25);

var birthdates = new DateTime[5]
{
    new DateTime(2000, 10, 1),
    new DateTime(2006, 12, 1),
    new DateTime(2000, 1, 1),
    new DateTime(2007, 6, 1),
    new DateTime(2000, 7, 1)
};

var names = new string[5]
{
    "John",
    "Bob",
    "G'ayrat",
    "Timmy",
    "Teshavoy"
};

var tempDate = default(DateTime);
var tempName = default(string);

for(var indexA = 0; indexA <  names.Length - 1; indexA++)
    for (var indexB = indexA + 1; indexB < names.Length - 1; indexB++)
        if (birthdates[indexA].DayOfYear > birthdates[indexB].DayOfYear)
        {
            tempDate = birthdates[indexA];
            birthdates[indexA] = birthdates[indexB];
            birthdates[indexB] = tempDate;

            tempName = names[indexA];
            names[indexA] = names[indexB];
            names[indexB] = tempName;
        }

for (var index = 0; index < names.Length; index++)
    Console.WriteLine(names[index] + " " + birthdates[index]);

#endregion