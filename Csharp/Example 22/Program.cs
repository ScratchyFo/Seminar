// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// • 5 -> 1, 4, 9, 16, 25.
// • 2 -> 1,4

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;

while (a <= N)
{
// Console.Write($"{a * a} ");
// a++;
    Console.Write($"{Math.Pow(a,2)}");
    if (a != N)
    {
        Console.Write(", ");
    }
    a++;
}