//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int result = num % 100;
int result2 = result / 10;

Console.WriteLine($"Вторая цифра от числа {num} -> {result2}");