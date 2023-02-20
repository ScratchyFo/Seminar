//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/* Если больше 3 символов то некорректно :=(
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int checkCount = num / 100;

if (checkCount == 0) {
    Console.WriteLine($"Заданое число не имеет третьей цифры");
} else {
    int result = num % 10;
    Console.WriteLine($"{result}");
}
*/

Console.Clear();

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

if (number > 99) {
    while (number > 999) {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine(result);
} else {
    Console.WriteLine("Треиьй цифры нет");
}