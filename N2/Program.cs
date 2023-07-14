#region Primitive types

using System.Runtime.InteropServices;

bool hasMoney = true;

char dollarSign = '$';

byte age = 50;

sbyte normalRoomTemperature = 22;

short balance = -1000;

ushort distance = 60_000;

int countryPopulation = 2_000_000_000;

uint manufacturedItems = 4_000_000_000;

long planets = 9_000_000_000_000_000_000;

ulong planetsB = 18_000_000_000_000_000_000;

float weight = 3.14159265358979323846F;

double pi = 3.14159265358979323846D;

decimal piDecimal = 3.14159265358979323846M;

string firstName = "John";

Console.WriteLine(piDecimal);
Console.WriteLine(Math.PI);

#endregion

#region Definition and Initialization

// Definition
byte ageB;
//Console.WriteLine(ageB);

// Do something ...

// Initialization
ageB = 15;

#endregion

#region Read and Write

int speedA = 100;
int speedB;

// Write operation for speed B
speedB = speedA;

// Read operation for speed B
speedA = speedB;

#endregion

#region Explicit va Implicity typing

// Implicit
var lastName = "Doe";

// Type doesn't change
//lastName = true;

// Initialization is a must
var ageZ = 10;
//var fullName;
//fullName = firstName + lastName;

// Explicit
int ageX = 10;

#endregion

#region Literals or Const Value

var boolValue = false;
var charValue = '@';
var byteValue = (byte)10;
var sbyteValue = (sbyte)10;
var intValue = 10;
var uintvalue = 10U;
var shortValue = (short)10;
var ushortValue = (ushort)10;
var longValue = 10L;
var ulongValue = 10UL;
var floatValue = 10F;
var doubleValue = 10D;
var decimalValue = 10M;
var stringValue = "Bob";

// Default value
int price = default;
var priceB = default(int);
Console.WriteLine($"Price: {price}");
bool defaultValue = true;
defaultValue = default;

string defaultStringValue = default;
string defaultStringValueB = string.Empty;

Console.WriteLine(defaultValue);

#endregion

#region Primitive and Complex types

// Primitive 
var productName = "Headphones";

// Complex
DateTime now = DateTime.Now;
Console.WriteLine(now);

#endregion

#region Value and Reference types

// Value type
var isWhite = false;

// Reference type
var address = "Bobur Shox ko'chasi, 8";

#endregion

#region Static va Dynamic

// Static
var modelNumber = "34567890";

// Dynamic

#endregion

#region Rules

// Rule #1 object bilan Member lariga murojaat qilib bo'maydi
object exampleObject = new User();
//exampleObject.Name = "Tom";

// Rule #2 Dynamic tipga xohlagan tipdagi qiymatni saqlash mumkin
object objectA = 10;
objectA = "firstName";
var unboxedString = (string)objectA;

// Rule #3 Primtiv tiplar ishlatilganda dynamic tiplar bilan boxing-unboxing sodir bo'ladi
// When used with primitive types, boxing-unboxing happens
Console.WriteLine(unboxedString);

// Can access members with dynamic
// Rule #4 Dynamic tipi bilan memberlariga murojaat qilish mumkin
dynamic objectB = new User();
objectB.Name = "Bob";
Console.WriteLine(objectB.Name);
//Console.WriteLine(objectB.LastName);

// Does change the address
// Rule #5 Agar o'zgaruvchi HEAP da joylashgan bo'lsa dynamic ga o'tkazilsa,
//  address o'zgarmaydi 
//var staticString = "string";
//object dynamicString = staticString;
//string unboxedStringB = (string)dynamicString;

//GCHandle handleA = GCHandle.Alloc(staticString, GCHandleType.Pinned);
//IntPtr pointerA = handleA.AddrOfPinnedObject();
//Console.WriteLine(pointerA.ToString());

//GCHandle handleB = GCHandle.Alloc(dynamicString, GCHandleType.Pinned);
//IntPtr pointerB = handleB.AddrOfPinnedObject();
//Console.WriteLine(pointerB.ToString());

//GCHandle handleC = GCHandle.Alloc(unboxedStringB, GCHandleType.Pinned);
//IntPtr pointerC = handleC.AddrOfPinnedObject();
//Console.WriteLine(pointerC.ToString());

#endregion

#region Built-in and Custom types

// Built-In type
var dateTime = new DateTime(2023, 7, 12);

// Custom Type
var foydalanuvchi = new User();

#endregion

#region Arrays
// Bir o'lchamli massiv
// Explicit e'lon qilganda tipida son ko'rsatilmaydi
int[] sonlarMassiviA = new int[] { 1, 2, 3 };

// E'lon qilganda tipida limitini berish mumkin
var sonlarMassiviC = new int[default];

// E'lon qilganda limit bilan boshlang'ich elemtlari soni teng bo'lishi shart
var sonlarMassiviB = new int[3] { 1, 2, 3 };

Console.WriteLine(sonlarMassiviB[0]);

// Massivda elementlar soni o'zgarmaydi va yo'q bo'lgan
// elementlarni murojaat qila olmaymiz
//sonlarMassiviB[3] = 40;
//sonlarMassiviB[-3] = 40;

// Massiv elementlaridan hammasi ishlatish majburiy emas
sonlarMassiviB[0] = 10;
//sonlarMassiviB[1] = 20;
sonlarMassiviB[2] = 30;

// Ikki o'lchamli massiv
var markazdagiXonalarA = new int[4,8];
var markazdagiXonalarB = new int[,]
{
    {1, 2, 3, 4, 5, 6, 7, 8},
    {1, 2, 3, 4, 5, 6, 7, 8},
    {1, 2, 3, 4, 5, 6, 7, 8},
    {1, 2, 3, 4, 5, 6, 7, 8},
};

// Jagged massiv
var markazdagiXonalarC = new int[][]
{
    new int[6],
    new int[8],
    new int[8],
    new int[5],
};

var markazdagiXonalarD = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {1, 2,4 },
    new int[] {1, 2, 3, 4,5 },
    new int[] {1,2,3}
};

var multiplyTable = new int[6, 3];

// 10 * 3
// 10 * 4
// 10 * 5
multiplyTable[0, 0] = 10;
multiplyTable[0, 1] = 3;

multiplyTable[1, 0] = 10;
multiplyTable[1, 1] = 4;

multiplyTable[2, 0] = 10;
multiplyTable[2, 1] = 5;

// Hisoblash
for(var index = 0; index < 3; index++)
    multiplyTable[index, 2] = multiplyTable[index, 0] * multiplyTable[index, 1];

for (var index = 0; index < 3; index++)
{
    for (var indexB = 0; indexB < 3; indexB++)
        Console.Write(multiplyTable[index, indexB] + " ");

    Console.WriteLine();
}

#endregion

public class User
{
    public string Name { get; set; }
}