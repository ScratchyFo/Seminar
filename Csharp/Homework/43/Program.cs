// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double X(int b1, int k1, int b2, int k2)
{
    double x1 = (b2 - b1);
    double x2 = (k1 - k2);
    double x = x1 / x2;
    return x;
}

double Y(int b1, int k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите точку B1: ");
int b1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите точку K1: ");
int k1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите точку B2: ");
int b2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите точку K2: ");
int k2 = int.Parse(Console.ReadLine()!);

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1, x);

Console.Write($"Точка пересечения ({x:f1}; {y:f1})");