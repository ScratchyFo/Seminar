//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;

while (a <= N)
{
    double cube = Math.Pow(a,3);
    Console.Write($"{cube}");

    if (a != N)
    {
        Console.Write(", ");
    }
    a++;
}