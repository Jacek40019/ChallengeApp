// task Day 4
// for the gender variable k - female, m - male
string name = "Kasia";
char gender = 'k';
var age = 17;

if (age < 30 && gender == 'k')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa" && gender == 'k')
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && gender == 'm')
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine(name + " lat " + age);
}