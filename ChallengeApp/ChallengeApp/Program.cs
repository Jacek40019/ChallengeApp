using ChallengeApp;
Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("----------------------------");
Console.WriteLine();


var employee = new Employee("Kim", "Young");
Console.WriteLine("Wprowadź oceny pracownika \nJeżeli chcesz zakończyć - wpisz literę q\n");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: "); 
    var input = Console.ReadLine();
    if (input == "q" || input =="Q")
    {
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistic();
Console.WriteLine($"Imię i nazwisko pracownika: {employee.Name} {employee.Surname}");

Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
Console.WriteLine($"Minimalna  ocena: {statistics.Min}");
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");
Console.WriteLine($"Średnia ocena: {statistics.AverageLetter}");




