//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату Ax: ");
double Ax = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату Az: ");
double Az = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Bx: ");
double Bx = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату By: ");
double By = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine()!);


double x = Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2);
double len = Math.Sqrt(x);

Console.Write($"Растояние в 3D: {len:f2}");