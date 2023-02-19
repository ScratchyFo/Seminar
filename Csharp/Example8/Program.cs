// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 н екратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4; 16, 4 -> кратно;

Console.Clear();

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);

int result = a % b;

if (result == 0)
{
    Console.WriteLine("Кратно");
}
else {
    Console.WriteLine($"Не кратно, остаток {result}");
}


