// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] getArray(int size, double min, double max)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (max - min) + min;
    }
    return res;
}

void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f2}  ");
    }
    Console.Write($"{array[array.Length - 1]:f2}");
    Console.WriteLine("]");
}

double[] array = getArray(5, 100, 999);
printArray(array);

double dMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double dMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.WriteLine($"Минимальное {dMin(array):f2}");
Console.WriteLine($"Максимальное {dMax(array):f2}");

double diff = dMax(array) - dMin(array);
Console.WriteLine($"Разница {diff:f2}");