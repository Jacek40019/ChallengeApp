// Task - day 6
// The program searches for the employee with the highest total score. 
// It then displays his data and score.


using ChallengeApp;


Employee employee1 = new Employee("Lee", "Wong", 34);
Employee employee2 = new Employee("Kim", "Jung", 53);
Employee employee3 = new Employee("Bao", "Yi", 27);

employee1.Addscores(3);
employee1.Addscores(8);
employee1.Addscores(9);
employee1.Addscores(6);
employee1.Addscores(9);

employee2.Addscores(6);
employee2.Addscores(0);
employee2.Addscores(9);
employee2.Addscores(5);
employee2.Addscores(3);

employee3.Addscores(9);
employee3.Addscores(6);
employee3.Addscores(8);
employee3.Addscores(2);
employee3.Addscores(7);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Pracownikiem z najwyższą liczbą ocen jest " + employeeWithMaxResult.Name +
" " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age + ". " + employeeWithMaxResult.Name +
" zdobył " + employeeWithMaxResult.Result + " punktów.");
