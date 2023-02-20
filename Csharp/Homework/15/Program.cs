//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine()!);

if (number > 5 && number < 8)
{
    Console.Write("Выходной"); 
}
else if (number > 0 && number < 6) 
{
    Console.Write("Рабочий день и ни как иначе");
}
else if (number < 1 || number > 7) 
{
    Console.Write("Нет таких дней в неделе");
}