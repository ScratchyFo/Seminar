// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7   -2   -0,2
// 1   -3,3  8   -9,9
// 8    7,8 -7,1 9

Console.Clear();

double[,] getArray2D(int m, int n, int min, int max)
{
    double[,] res = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return res;
}

void printArray2D(double[,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0);i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Console.Write($"{Array2D[i,j]:f1}\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Размер массива m:");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Размер массива n:");
int n = int.Parse(Console.ReadLine()!);

double[,] myArray2D = getArray2D(m, n, -30, 20);
printArray2D(myArray2D);