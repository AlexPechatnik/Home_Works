/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] array = new int[2, 2];
int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];
int[,] proi = new int[array.GetLength(0), array.GetLength(1)];
// Заполняем двумерный массив array
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

// Заполняем двумерный массив matrix
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        System.Console.Write(matrix[i, j] + " ");
    }
    System.Console.WriteLine("");
}
System.Console.WriteLine("");

int rows1 = array.GetLength(0);
int cols1 = array.GetLength(1);

int rows2 = matrix.GetLength(0);
int cols2 = matrix.GetLength(1);

// Проверка возможности умножения матриц
if (cols1 != rows2)
{
    Console.WriteLine("Матрицы не могут быть перемножены");
    return;
}
// перемножаем две матрицы
int[,] result = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < cols1; k++)
        {
            result[i, j] += array[i, k] * matrix[k, j];
        }
    }
}

Console.WriteLine("Результат умножения двух матриц:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}