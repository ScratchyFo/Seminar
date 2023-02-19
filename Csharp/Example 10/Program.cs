// Напишите программу, которая принимает 2  числа и проверяет явялется ли оно квадартом числа другого
Console.Clear();

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);


if ( a * a == b || b * b == a ) {
    Console.WriteLine("Является квадратом");
} else {
    Console.WriteLine("Не является квадратом");
}