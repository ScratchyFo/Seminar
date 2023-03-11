// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArraySpiral(int m, int n)
{
    int s = 1;
    int[,] array = new int[m, n];

    //Заполняем периметр массива по часовой стрелке.
    for (int y = 0; y < n; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x, n - 1] = s;
        s++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1, y] = s;
        s++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    //Периметр заполнен. Продолжаем заполнять массив и задаём
    //координаты ячейки, которую необходимо заполнить следующей.
    int c = 1;
    int d = 1;

    while (s < m * n)
    {
        //Движемся вправо.
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }

        //Движемся вниз.
        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }

        //Движемся влево.
        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }

        //Движемся вверх.
        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }
    //При данном решении в центре всегда остаётся незаполненная ячейка.
    //Убираем её при помощи следующего цикла.
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите высоту массива: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите ширину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array2D = FillArraySpiral(m, n);
PrintArray(array2D);