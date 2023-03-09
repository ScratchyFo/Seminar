// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такой позиции нет
int[,] getArray2D(int m, int n, int min, int max)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(min, max+1);
        }
    }

    return res;
}

void printArray2D(int[,] inArray2D)
{
    for (int i = 0; i < inArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2D.GetLength(1); j++)
        {
            Console.Write($"{inArray2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

string findArray2D(int m, int n, int[,] inArray2D)
{
    if (m < 0 || n < 0) return "значения должны быть натуральными";
    string res;
    if (m <= inArray2D.GetLength(0) - 1 && n <= inArray2D.GetLength(1) - 1)
    {
        res = $"[{m} ; {n}] >> {inArray2D[m, n]}";
    }
    else
    {
        res = $"[{m} ; {n}] >>  такой позиции нет";
    }
    return res;
}

Console.Clear();

int[,] inArray2D = getArray2D(5, 5, 0, 20);

printArray2D(inArray2D);
Console.Write("Введите позицию через пробел: ");

string[] s = Console.ReadLine()!.Split();

int m = Convert.ToInt32(s[0]);
int n = Convert.ToInt32(s[1]);

Console.Write(findArray2D(m, n, inArray2D));
