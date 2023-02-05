// Программа возведения числа в квадрат.

Console.Clear();

Console.WriteLine("Введите число: ");

// При вводе 99999 - по методу sqr ответ некорректен.
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;

// При вводе 99999 - по методу sqr ответ некорректен.
// Int32 number = int.Parse(Console.ReadLine()!);
// Int32 sqr = number * number;

// При вводе 99999 - ответ стабилен вроде как.
// Int64 number = int.Parse(Console.ReadLine()!);
// Int64 sqr = number * number;
double sqr2 = Math.Pow(number, 2);

Console.WriteLine($"Квадрат числа {number} равен {sqr}");
Console.WriteLine($"Квадрат числа {number} равен {sqr2}");
