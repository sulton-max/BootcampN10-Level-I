using System;

var workStartTime = new TimeOnly(9, 0);
var workEndTime = new TimeOnly(18, 0);

var meetingA = new DateTime(2023, 7, 18, 9, 0, 0);
var meetingB = new DateTime(2023, 7, 18, 18, 0, 0);

var meetingStartTime = new DateTimeOffset[10];
meetingStartTime[0] = new DateTimeOffset(meetingA.AddMinutes(-10), TimeSpan.Zero);
meetingStartTime[1] = new DateTimeOffset(meetingB.AddMinutes(400), TimeSpan.Zero);
meetingStartTime[2] = new DateTimeOffset(meetingA.AddMinutes(10), TimeSpan.Zero);
meetingStartTime[3] = new DateTimeOffset(meetingA.AddMinutes(-10), TimeSpan.Zero);
meetingStartTime[4] = new DateTimeOffset(meetingB.AddMinutes(-10), TimeSpan.Zero);
meetingStartTime[5] = new DateTimeOffset(meetingA.AddMinutes(100), TimeSpan.Zero);
meetingStartTime[6] = new DateTimeOffset(meetingB.AddMinutes(-200), TimeSpan.Zero);
meetingStartTime[7] = new DateTimeOffset(meetingB.AddMinutes(-10), TimeSpan.Zero);
meetingStartTime[8] = new DateTimeOffset(meetingA.AddMinutes(20), TimeSpan.Zero);
meetingStartTime[9] = new DateTimeOffset(meetingB.AddMinutes(-10), TimeSpan.Zero);

var meetingEndTime = new TimeSpan[10];
meetingEndTime[0] = TimeSpan.FromMinutes(10);
meetingEndTime[1] = TimeSpan.FromMinutes(20);
meetingEndTime[2] = TimeSpan.FromMinutes(20);
meetingEndTime[3] = TimeSpan.FromMinutes(10);
meetingEndTime[4] = TimeSpan.FromMinutes(2);
meetingEndTime[5] = TimeSpan.FromMinutes(100);
meetingEndTime[6] = TimeSpan.FromMinutes(20);
meetingEndTime[7] = TimeSpan.FromMinutes(200);
meetingEndTime[8] = TimeSpan.FromMinutes(100);
meetingEndTime[9] = TimeSpan.FromMinutes(20);

Console.WriteLine("Meeetings : ");
for (var index = 0; index < meetingStartTime.Length; index++)
{
    Console.WriteLine($"{meetingStartTime[index]} and duration - {meetingEndTime[index]}");
}

var test = meetingStartTime[0] + meetingEndTime[0];

Console.WriteLine("Bad Meeetings : ");
for (var index = 0; index < meetingStartTime.Length; index++)
{
    // version 1
    if (meetingStartTime[index].Hour < workStartTime.Hour
        || meetingStartTime[index].Hour > workEndTime.Hour
        || (meetingStartTime[index] + meetingEndTime[index]).Hour > workEndTime.Hour)
        Console.WriteLine($"{meetingStartTime[index]} and duration - {meetingEndTime[index]}");

    // version 2 - for end meeting time with date time
    //if (workStartTime.Hour <= meetingEndTime[index].Hour && workEndTime.Hour >= meetingStartTime[index].Hour)
    //    Console.WriteLine($"{meetingStartTime[index]} and duration - {meetingEndTime[index]}");
}

var totalDuration = 0D;
for (var index = 0; index < meetingStartTime.Length; index++)
    totalDuration += meetingEndTime[index].TotalMinutes;

Console.WriteLine($"Total minutes : {totalDuration}");

for (var index = 0; index < meetingStartTime.Length; index++)
{
    // version 1
    if (meetingStartTime[index].Hour < workStartTime.Hour
        || meetingStartTime[index].Hour > workEndTime.Hour
        || (meetingStartTime[index] + meetingEndTime[index]).Hour > workEndTime.Hour)
        Console.WriteLine($"{meetingStartTime[index]} and duration - {meetingEndTime[index]}");

    // version 2 - for end meeting time with date time
    //if (workStartTime.Hour <= meetingEndTime[index].Hour && workEndTime.Hour >= meetingStartTime[index].Hour)
    //    Console.WriteLine($"{meetingStartTime[index]} and duration - {meetingEndTime[index]}");
}
