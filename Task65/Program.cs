// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void RangeNatureNumbers (int numA, int numB)
{
    if(numA == numB)
    {
        Console.Write($"{numA}");
    }
    else if (numA > numB)
    {
        Console.Write($"{numA} ");
        RangeNatureNumbers(numA - 1, numB);
    }
    else
    {
        Console.Write($"{numA} ");
        RangeNatureNumbers(numA + 1, numB);
    }
}

Console.WriteLine("Введите первое натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"{numberM}, {numberN} -> ");
RangeNatureNumbers(numberN, numberM);