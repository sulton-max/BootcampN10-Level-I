// Date Types

// Date Time

// Creation - e'lon qilish variantlari
// Date Time - sana uchun
// tick - 100 nano second 
// date 
// date and time 
// 

//var exampleDate = new DateTime()
// 1970 1 Jan - Unix Epoch

var dateTime = DateTime.Now;

Console.WriteLine($"dateTime.Year - {dateTime.Year}");
Console.WriteLine($"dateTime.Month - {dateTime.Month}");
Console.WriteLine($"dateTime.Day - {dateTime.Day}");
Console.WriteLine($"dateTime.DayOfWeek - {dateTime.DayOfWeek}");
Console.WriteLine($"dateTime.DayOfYear - {dateTime.DayOfYear}");
Console.WriteLine($"dateTime.TimeOfDay - {dateTime.TimeOfDay}");
Console.WriteLine($"dateTime.Hour - {dateTime.Hour}");
Console.WriteLine($"dateTime.Minute - {dateTime.Minute}");
Console.WriteLine($"dateTime.Second - {dateTime.Second}");

Console.WriteLine($"DateTimeKind.Utc - {DateTime.UtcNow}");
Console.WriteLine($"DateTimeKind.Local - {DateTime.Now}");

Console.WriteLine($"DateTime.MinValue - {DateTime.MinValue}");
Console.WriteLine($"DateTime.MaxValue - {DateTime.MaxValue}");
Console.WriteLine($"DateTime.Today - {DateTime.Today}");
Console.WriteLine($"DateTime.UnixEpoch - {DateTime.UnixEpoch}");
Console.WriteLine($"DateTime.DaysInMonth - {DateTime.DaysInMonth(2021, 1)}");
Console.WriteLine($"DateTime.IsLeapYear - {DateTime.IsLeapYear(2023)}");

// Date Only
Console.WriteLine(new DateOnly(2023, 7, 18));

// Time Only
Console.WriteLine(new TimeOnly(10, 10, 10));

// DateTimeOffset - sana va vaqtni UTC dan farqi bilan saqlaydi
var dateTimeOffset = new DateTimeOffset(dateTime);
Console.WriteLine(dateTime);
Console.WriteLine(dateTimeOffset);
Console.WriteLine(dateTimeOffset.UtcDateTime.ToString());

// TimeSpan - oraliq vaqt
// MethodA();
Console.WriteLine(TimeSpan.FromMinutes(10));
Console.WriteLine((DateTime.Now - DateTime.UtcNow).TotalSeconds);
Console.WriteLine(DateTime.Now - DateTime.MinValue);


var testA = new DateTime(2023, 7, 18, 20, 18, 00);
var testB = new DateTime(2023, 7, 18, 20, 18, 00, DateTimeKind.Utc);

var offset = TimeSpan.FromMinutes((DateTime.UtcNow - DateTime.Now).Minutes);
var testC = new DateTimeOffset(testA);
var testD = new DateTimeOffset(testA, offset);

Console.WriteLine(testB.ToString());
Console.WriteLine(testA.ToString());

Console.WriteLine(testC);
Console.WriteLine(testD);

Console.WriteLine(testC.UtcDateTime);
Console.WriteLine(testD.UtcDateTime);

//Console.Write()