using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Исходный двумерный массив
        int[,] matrix = new int[,]
        {
            { 3, 2, 1 },
            { 6, 5, 4 },
            { 9, 8, 7 }
        };

        // Создание нового одномерного массива для сортировки
        int[] sortedArray = new int[matrix.Length];

        // Копирование значений из двумерного массива в одномерный массив
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sortedArray[i * matrix.GetLength(1) + j] = matrix[i, j];
            }
        }

        // Сортировка одномерного массива в порядке убывания
        Array.Sort(sortedArray);
        Array.Reverse(sortedArray);

        // Копирование отсортированных значений обратно в двумерный массив
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = sortedArray[i * matrix.GetLength(1) + j];
            }
        }

        // Вывод отсортированного двумерного массива
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
