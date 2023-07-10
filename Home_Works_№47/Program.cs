/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

double[,] array = new double[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine("");
}
