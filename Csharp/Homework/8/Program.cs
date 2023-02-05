//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k=k + 2;
}