/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int[,] array = new int[5, 4];

int[] sortedArray = new int[array.Length];

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

// Копирование значений из двумерного массива в одномерный массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sortedArray[i * array.GetLength(1) + j] = array[i, j];
    }
}

// Вывод одномерного массива массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write(sortedArray[i] + " ");
}
System.Console.WriteLine(" ");
// Сортировка одномерного массива
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (sortedArray[i] < sortedArray[j])
        {
            // Обмен значениями элементов массива
            int temp = sortedArray[i];
            sortedArray[i] = sortedArray[j];
            sortedArray[j] = temp;
        }
    }
}
// Вывод отсортированного массива
for (int i = 0; i < array.Length; i++)
{
    Console.Write(sortedArray[i] + " ");
}
System.Console.WriteLine(" ");
System.Console.WriteLine(" ");

// Копирование отсортированных значений обратно в двумерный массив
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = sortedArray[i * array.GetLength(1) + j];
                System.Console.Write(array[i, j] + " ");
            }
            System.Console.WriteLine(" ");
        }