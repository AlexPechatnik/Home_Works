﻿/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 5);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine("");
}
System.Console.WriteLine("");

for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0;
    double avResult = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum = sum + array[j, i];
    }
    avResult = Math.Round(sum / array.GetLength(0),1);
    System.Console.WriteLine($"Ср. ар. столбца {i}: {avResult}");
}
