// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void RangeNatureNumbers(int numA, int numB)
{
    Console.Write(Sum(numA - 1, numB));
}

int Sum(int numA, int numB)
{
    int res = numA;
    if (numA == numB) return 0;
    else
    {
        numA++;
        res = numA + Sum(numA, numB);
        return res;
    }
}

Console.WriteLine("Введите первое натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"{numberM}, {numberN} -> ");
RangeNatureNumbers(numberN, numberM);