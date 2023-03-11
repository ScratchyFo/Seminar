// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] fillArraySpiral(int a, int b)
{
    int[,] array = new int[a, b];
    int s = 1;
    
    // Наполнение массива по часовой

    for (int y = 0; y < b; y++)
    {
        array[0, y] = s;
        s++;
    }

    for (int x = 1; x < a; x++)
    {
        array[x, b - 1] = s;
        s++;
    }

    for (int y = b - 2; y >= 0; y--)
    {
        array[a - 1, y] = s;
        s++;
    }

    for (int x = a - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;
    int d = 1;

    while (s < a * b)
    {
        // Вправо
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }

        // Вниз
        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }

        // Влево
        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }

        // Вверх
        while (array[c - 1, d] == 0)
        {
            s = array[c, d];
            s++;
            c--;
        }
    }
  
    for (int x = 0; x < a; x++)
    {
        for (int y = 0; y < b; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
    return array;
}


void printArray(int[,] array)
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

int[,] array2D = fillArraySpiral(m, n);
printArray(array2D);