using System.Diagnostics;
using N32_T5;

var stopwatch = new Stopwatch();
stopwatch.Start();

for (var index = 0; index < 100_000; index++)
{
    var result = CustomValidator.IsValidEmailAddress("test.com");
    if (result.Any())
    {
        Console.WriteLine("Email address is invalid");
        result.ForEach(Console.WriteLine);
    }
}

// display elapsed in milliseconds
stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");