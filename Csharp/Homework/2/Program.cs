// Задача: 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int min = 0;
int max = 0;

if (a != b) {
    if (a > b) {
        Console.WriteLine("Число a больше чем b");
        min = b;
        max = a;
    } else if (a < b) {
        Console.WriteLine("Число a меньше чем b");
        min = a;
        max = b;
    }
    Console.WriteLine($"Минимальное число = {min}, максимальное число = {max}");
} else {
    Console.WriteLine("Числа равны между собой");
}






