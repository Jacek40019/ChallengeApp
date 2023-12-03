using ChallengeApp;
using Microsoft.VisualBasic;

Console.WriteLine("Program do oceny pracowników");
Console.WriteLine("----------------------------");
Console.WriteLine();

Console.WriteLine("Wybierz czyje oceny chcesz wprowadzić:\n k - kierownik\n p - pracownik");
var select = Console.ReadLine();

var employee = new Employee("Kim", "Young", 27);
var supervisor = new Supervisor("Lee", "Bao", 49);

if (select == "k" || select == "K")
{
    Console.WriteLine("Wprowadź oceny kierownika \nJeżeli chcesz zakończyć - wpisz literę q\n");

    while (true)
    {
        Console.WriteLine("Podaj ocenę kierownika: ");
        var input = Console.ReadLine();
        if (input == "q" || input == "Q")
        {
            break;
        }

        try
        {
            supervisor.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exeption catched: {e.Message}");
        }
    }
    var statistics = supervisor.GetStatistic();
    Console.WriteLine($"Imię i nazwisko kierownika: {supervisor.Name} {supervisor.Surname}, wiek: {supervisor.Age} lat");
    Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
    Console.WriteLine($"Minimalna  ocena: {statistics.Min}");
    Console.WriteLine($"Średnia z ocen: {statistics.Average:N2}");
    Console.WriteLine($"Średnia ocena (A - E): {statistics.AverageLetter}");
}

if (select == "p" || select == "P")
{
    Console.WriteLine("Wprowadź oceny pracownika \nJeżeli chcesz zakończyć - wpisz literę q\n");

    while (true)
    {
        Console.WriteLine("Podaj ocenę pracownika: ");
        var input = Console.ReadLine();
        if (input == "q" || input == "Q")
        {
            break;
        }

        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exeption catched: {e.Message}");
        }
    }
    var statistics = employee.GetStatistic();
    Console.WriteLine($"Imię i nazwisko pracownika: {employee.Name} {employee.Surname}, wiek: {employee.Age} lat");
    Console.WriteLine($"Maksymalna ocena: {statistics.Max}");
    Console.WriteLine($"Minimalna  ocena: {statistics.Min}");
    Console.WriteLine($"Średnia z ocen: {statistics.Average:N2}");
    Console.WriteLine($"Średnia ocena (A - E): {statistics.AverageLetter}");
}




