// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] getMatrix(int a, int b, int min, int max)
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] multipMatrix(int[,] mA, int[,] mB)
{
    int[,] mC = new int[mA.GetLength(0), mB.GetLength(1)];
    if (mA.GetLength(1) != mB.GetLength(0))
    {
        Console.WriteLine("Ошибка умножения мматриц");
        return mC;
    }
    for (int i = 0; i < mC.GetLength(0); i++)
    {
        for (int j = 0; j < mC.GetLength(1); j++)
        {
            for (int k = 0; k < mA.GetLength(1); k++)
            {
                mC[i, j] += mA[i, k] * mB[k, j];
            }

        }
    }
    return mC;
}

Console.Clear();

Console.Write("Введите матрицу A через запятую: ");
int[] dimA = Array.ConvertAll(Console.ReadLine()!.Split(','), Convert.ToInt32);
int[,] mA = getMatrix(dimA[0], dimA[1], 0, 9);

Console.Write("Введите матрицу B через запятую: ");
int[] dimB = Array.ConvertAll(Console.ReadLine()!.Split(','), Convert.ToInt32);
int[,] mB = getMatrix(dimB[0], dimB[1], 0, 9);

printMatrix(mA);
Console.WriteLine();
printMatrix(mB);

int[,] mC = multipMatrix(mA, mB);
Console.WriteLine();
printMatrix(mC);
