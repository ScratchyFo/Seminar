// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($" {inArray2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

string getAvgArray2D(int[,] inArray2D)
{
    string res = "";
    double sum;
    double avg;
    for (int i = 0; i < inArray2D.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray2D.GetLength(0); j++)
        {
            sum += inArray2D[j, i];
        }
        avg = sum / inArray2D.GetLength(0);
        res += $"{avg:f1}\t ";
    }
    res += "среднее арифметическое столбцов";
    return res;
}

Console.Clear();

int[,] inArray2D = getArray2D(4, 5, 0, 10);

printArray2D(inArray2D);
Console.WriteLine(getAvgArray2D(inArray2D));