using ChallengeApp;

var employee = new Employee("Kim", "Young");
employee.AddGrade(7);
employee.AddGrade(9);
employee.AddGrade(4.27F);
var statistics = employee.GetStatistic();
Console.WriteLine($"Maxymalna ocena = {statistics.Max}");
Console.WriteLine($"Minimalna ocena = {statistics.Min}");
Console.WriteLine($"Średnia ocena = {statistics.Average:N2}");


