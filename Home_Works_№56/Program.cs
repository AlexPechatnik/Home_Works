/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка.
*/
int[,] array = new int[10, 10];
int[] matrix = new int[array.Length];

// Заполняем двумерный массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine("");
}
System.Console.WriteLine("");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        matrix[i] += array[i, j];

    }
    System.Console.WriteLine($"сумма чисел в строке {i + 1} = {matrix[i]} ");
}

int min = matrix[0];
for (int i = 0; i < array.GetLength(0); i++)
{
    if (matrix[i] < min)
    {
        min = matrix[i];
    }
}

for (int i = 0; i < array.Length; i++)
{
    if (min == matrix[i])
    {
        System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i + 1} = {matrix[i]}");
        return;
    }
}