/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/
Console.WriteLine("Введите координату b1");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату k1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату k2");
double k2 = int.Parse(Console.ReadLine());
double y = 0;
double y2 = 0;
double x = -2.5/k1;
double x1 = -2.5/k2;
y = k1 * x + b1;
y2 = k2 * x1 + b2;
Console.WriteLine($"{y};{y2};{x};{x1}");