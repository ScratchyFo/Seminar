// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;


if (a > b) {
    max = a;
}  
if (b > c) {
    max = b;
}
if (c > max) {
    max = c;
}
Console.WriteLine($"Максимальное число {max}");

