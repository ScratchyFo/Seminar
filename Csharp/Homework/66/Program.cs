// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumElements(int m, int n)
{
    int res = m;
    if (m == n) return m;
    m++;
    res = res + sumElements(m, n);
    return res;
}

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма натуральных элементов: {sumElements(m, n)}");