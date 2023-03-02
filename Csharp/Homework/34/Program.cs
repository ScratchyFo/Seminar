// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] getArray(int size, int min, int max)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max+1);
    }
    return res;
}
int even(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) res++;
    }
    return res;
}

int[] array = getArray(4, 100, 999);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");

int res = even(array);
Console.Write($" -> {res} четных числа в массиве");