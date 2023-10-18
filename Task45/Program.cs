// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] GenerateArray(int min, int max, int size)
{
    int[] arr = new int[size];
    var rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[] CopyArray(int[] arr)
{
    int[] arrayA = new int[arr.Length];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arrayA[i] = arr[i];
    }
    return arrayA;
}

int[] res = GenerateArray(1, 10, 5);

PrintArray(res);

int[] resA = CopyArray(res);
resA[0] = 10000;

int[] resB = res; // ссылка на исходный массив res
res[3] = -100;

// PrintArray(resA);

PrintArray(resB);