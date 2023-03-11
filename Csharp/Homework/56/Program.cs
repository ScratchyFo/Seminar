// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] getArray(int a, int b, int min, int max)

{
    int[,] res = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            res[i, j] = new Random().Next(min, max + 1);
        }
    }

    return res;
}

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void arraySum (int[,] array2D)
{
    int line = 0;
    int sumMin = Int32.MaxValue;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum = sum + array2D[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            line++;
        }
        
    }
    Console.Write($"Наименьшая сумма у строки {line}");
}

Console.Clear();

int[,] array2D = getArray(4, 3, 0, 9);
printArray(array2D);

Console.WriteLine();

arraySum(array2D);