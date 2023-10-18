// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первую сторону: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую сторону: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью сторону: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}


bool res = IsExistTriangle(numA, numB, numC);

Console.WriteLine(res ? "Треугольник существует": "Треугольник не существует");