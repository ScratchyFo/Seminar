// Задача 14. Напишите программу, которая принимает на вод число и проверяет, кратно ли оно одновременно  7 и 23.

Console.Clear();

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
int b = 7;
int c = 23;

int result1 = a % b;
int result2 = a % c;

if (result1 == 0 && result2 == 0)
{
    Console.WriteLine("Кратно");
}
else {
    Console.WriteLine($"Не кратно");
}


