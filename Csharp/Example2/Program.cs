﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число a");


int a = int.Parse(Console.ReadLine());


Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if (a == b*b) {
    Console.WriteLine("Число a является квадратом b");
} else {
    Console.WriteLine("Число a не является квадратом b");
}