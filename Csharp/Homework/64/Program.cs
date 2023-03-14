// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int count = 1;
string printNumbers(int n, int count)

{
    if (count == n) return $"{n}";
    return printNumbers(n, count + 1) + $", {count}";
}

Console.Clear();
Console.Write("Введите число N: ");

int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(n, count));