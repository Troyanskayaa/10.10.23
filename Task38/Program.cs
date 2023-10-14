// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите массив вещественных чисел");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("");
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    return max-min;
}

// void ArrayRandomNumbers(double[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(99,999) / 100;
//     }
// }

int[] ArrayRandomNumbers(int size, int min, int max)
{
    int[] numbers = new double[size];
    Random rnd = new Random();

    for (int i=0; i < size; i++)
    {
        numbers[i] = rnd.Next(min, max + 1);
    }
    return numbers;
}


void PrintArray(double[] number)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}

Console.Write("]");
Console.WriteLine();