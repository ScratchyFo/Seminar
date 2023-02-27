/// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int PowerMatch(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    return res;
}

Console.Write("Введите возводимое: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {a} в степени {b} = {PowerMatch(a, b)}");