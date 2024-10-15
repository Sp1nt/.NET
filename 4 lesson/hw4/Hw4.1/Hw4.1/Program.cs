
using Hw4._1;


MyDatesList date1 = new();
MyDatesList date2 = new(13, 11, 2024);

Console.WriteLine(date1.PrintDate());
Console.WriteLine(date1.Day_Of_Week);

Console.WriteLine(date2.PrintDate());
Console.WriteLine(date2.Day_Of_Week);

Console.WriteLine("Diff between two dates: " + date1.DaysDiff(date2) + " days");


date1.AddDaysToDate(250);
Console.WriteLine("New date days: " + date1.PrintDate());