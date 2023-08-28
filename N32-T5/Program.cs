using System.Diagnostics;
using N32_T5;

var stopwatch = new Stopwatch();
stopwatch.Start();

for (var index = 0; index < 100_000; index++)
    CustomValidator.IsValidEmailAddress(null);

stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
stopwatch.Restart();

for (var index = 0; index < 100_000; index++)
    CustomValidator.IsValidEmailAddress("");

stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
stopwatch.Restart();

for (var index = 0; index < 100_000; index++)
    CustomValidator.IsValidEmailAddress("test.co@m");

stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");

// With nested if
// Elapsed time: 8 ms
// Elapsed time: 0 ms
// Elapsed time: 38 ms

// Without nested if
// Elapsed time: 10 ms
// Elapsed time: 0 ms
// Elapsed time: 68 ms



