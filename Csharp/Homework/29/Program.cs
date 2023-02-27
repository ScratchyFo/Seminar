//// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

Console.Clear();

Console.Write("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine()!);

int[] getArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void printArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)

    Console.Write($"{inArray[i]} ");
}


int[] array = getArray();
printArray(array);