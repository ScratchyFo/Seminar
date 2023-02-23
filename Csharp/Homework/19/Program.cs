//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num % 100 / 10;
int num5 = num % 10;

if (num < 9999 || num > 100000)
{
    Console.Write("Число должно быть 5-значным.");
}
else if (num1 == num5 && num2 == num4)
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндромом");
}
