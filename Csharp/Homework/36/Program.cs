// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int sum(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}

int[] array = getArray(4, -999, 999);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");

int res = sum(array);
Console.Write($" -> {res} сумма элементов нечетных позиций");