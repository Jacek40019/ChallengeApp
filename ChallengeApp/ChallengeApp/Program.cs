// task Day 5

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

var counter0 = 0;
var counter1 = 0;
var counter2 = 0;
var counter3 = 0;
var counter4 = 0;
var counter5 = 0;
var counter6 = 0;
var counter7 = 0;
var counter8 = 0;
var counter9 = 0;


foreach (var letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    if (letter == '1')
    {
        counter1++;
    }
    if (letter == '2')
    {
        counter2++;
    }
    if (letter == '3')
    {
        counter3++;
    }
    if (letter == '4')
    {
        counter4++;
    }
    if (letter == '5')
    {
        counter5++;
    }
    if (letter == '6')
    {
        counter6++;
    }
    if (letter == '7')
    {
        counter7++;
    }
    if (letter == '8')
    {
        counter8++;
    }
    if (letter == '9')
    {
        counter9++;
    }
}

Console.WriteLine("Wynik dla liczby " + number);
Console.WriteLine("0 => " + counter0);
Console.WriteLine("1 => " + counter1);
Console.WriteLine("2 => " + counter2);
Console.WriteLine("3 => " + counter3);
Console.WriteLine("4 => " + counter4);
Console.WriteLine("5 => " + counter5);
Console.WriteLine("6 => " + counter6);
Console.WriteLine("7 => " + counter7);
Console.WriteLine("8 => " + counter8);
Console.WriteLine("9 => " + counter9);