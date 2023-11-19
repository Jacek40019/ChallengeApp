using ChallengeApp;

var employee = new Employee("Kim", "Young");
double maxDoubleValue = double.MaxValue;
long maxLongValue = long.MaxValue;
decimal maxDecimalValue = decimal.MaxValue;

employee.AddGrade(maxDoubleValue);
employee.AddGrade(maxLongValue);
employee.AddGrade(maxDecimalValue);
employee.AddGrade(667);
employee.AddGrade("7");
employee.AddGrade(9);
employee.AddGrade(4.27);
var statistics = employee.GetStatistic();
Console.WriteLine($"Maxymalna ocena = {statistics.Max:N2}");
Console.WriteLine($"Minimalna ocena = {statistics.Min}");
Console.WriteLine($"Średnia ocena = {statistics.Average:N2}");




