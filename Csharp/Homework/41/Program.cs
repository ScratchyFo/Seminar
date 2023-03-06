// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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

int getPositive(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.Write("Введите количество чисел: ");

int size = int.Parse(Console.ReadLine()!);
int[] array = getArray(size, -99, 99);

Console.WriteLine(String.Join(", ", array));

if (getPositive(array) == 0)
{
    Console.Write($"Чисел больше 0 ннет ");
}
else
{
    Console.Write($"Чисел больше 0 => {getPositive(array)}");
}