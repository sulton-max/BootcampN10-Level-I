// Primitive types
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

// Definition and Initialization
// Definition
byte ageB;
//Console.WriteLine(ageB);

// Do something ...

// Initialization
ageB = 15;

// Read and Write
int speedA = 100;
int speedB;

// Write operation for speed B
speedB = speedA;

// Read operation for speed B
speedA = speedB;

// Explicit va Implicity typing

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

// Literals or Const Value
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

// Primitive and Complex types
// Primitive 
var productName = "Headphones";

// Complex
DateTime now = DateTime.Now;
Console.WriteLine(now);

// Value and Reference types









