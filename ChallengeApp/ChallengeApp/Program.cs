using ChallengeApp;

var employee = new Employee("Kim", "Young");
employee.AddGrade(667);
employee.AddGrade("77");
employee.AddGrade(9);
employee.AddGrade(4.27);

var statistics1 = employee.GetStatisticWithForEach();
var statistics2 = employee.GetStatisticWithFor();
var statistics3 = employee.GetStatisticWithDoWhile();
var statistics4 = employee.GetStatisticWithWhile();

Console.WriteLine("Rozwiazanie zadania - pętla foreach:");
Console.WriteLine($"Maxymalna ocena = {statistics1.Max:N2}");
Console.WriteLine($"Minimalna ocena = {statistics1.Min:N2}");
Console.WriteLine($"Średnia ocena = {statistics1.Average:N2}");

Console.WriteLine("Rozwiazanie zadania - pętla for:");
Console.WriteLine($"Maxymalna ocena = {statistics2.Max:N2}");
Console.WriteLine($"Minimalna ocena = {statistics2.Min:N2}");
Console.WriteLine($"Średnia ocena = {statistics2.Average:N2}");

Console.WriteLine("Rozwiazanie zadania - pętla do while:");
Console.WriteLine($"Maxymalna ocena = {statistics3.Max:N2}");
Console.WriteLine($"Minimalna ocena = {statistics3.Min:N2}");
Console.WriteLine($"Średnia ocena = {statistics3.Average:N2}");

Console.WriteLine("Rozwiazanie zadania - pętla while:");
Console.WriteLine($"Maxymalna ocena = {statistics4.Max:N2}");
Console.WriteLine($"Minimalna ocena = {statistics4.Min:N2}");
Console.WriteLine($"Średnia ocena = {statistics4.Average:N2}");




