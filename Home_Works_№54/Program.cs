/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int[,] array = new int[3, 4];
int[,] matrix = new int [3,4];
int max = 0;
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

for (int a = 0; a < matrix.GetLength(1); a++)
{
    for (int d = 0; d < matrix.GetLength(0); d++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                if (array[i, j] >= max)
                {
                    max = array[i, j];
                }
            }
        }
        matrix[a, d] = max;
        System.Console.WriteLine(matrix[a, d]);
    }
    System.Console.WriteLine(" ");
}