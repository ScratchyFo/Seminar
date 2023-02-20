// Напишите программу, которая выводит случайное число из отрезка [10;99]
//и показывает наибольшую цифру числа

Console.Clear();

int num = new Random().Next(10, 100); // 10 - 99

int a1 = num / 10; // цел
int a2 =  num % 10; // десят

int max = a1;
if (a2 > max) {
    max = a2;
}

Console.WriteLine($"Максимальная цифра {num} равна {max}");