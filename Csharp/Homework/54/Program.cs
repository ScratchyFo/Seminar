// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void arraySortLower(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            for (int c = 0; c < array2D.GetLength(1) - 1; c++)
            {
                if (array2D[i, c] < array2D[i, c + 1])
                {
                    int temp = 0;
                    temp = array2D[i, c];
                    array2D[i, c] = array2D[i, c + 1];
                    array2D[i, c +1] = temp;
                }
            }
        }
    }
}

Console.Clear();

int[,] array2D = getArray(3, 4, 0, 10);
printArray(array2D);

Console.WriteLine();

arraySortLower(array2D);

printArray(array2D);