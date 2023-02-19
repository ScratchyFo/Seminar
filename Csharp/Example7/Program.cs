// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет  вторую цифру этого числа
// 456 -> 46 ;  782 -: 72 ; 918 -> 98

Console.Clear();

int num = new Random().Next(100, 1000);

int a1 = num / 100; // левая
int a2 =  num % 10; // правая

Console.WriteLine($"{num}");

int result = a1*10+a2;
Console.WriteLine($"{result}");





