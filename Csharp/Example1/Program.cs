// Программа возведения числа в квадрат.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;
double sqr2 = Math.Pow(number, 2);

Console.WriteLine($"Квадрат числа {number} равен {sqr}");
Console.WriteLine($"Квадрат числа {number} равен {sqr2}");
