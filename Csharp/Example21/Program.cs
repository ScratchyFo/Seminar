// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.Write("Введите координаты точки Xa: ");
int Xa = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки Ya: ");
double Ya = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты точки Xb: ");
double Xb = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты точки Xb: ");
double Yb = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2);
double len = Math.Sqrt(x);

Console.WriteLine($"{len:f2}");