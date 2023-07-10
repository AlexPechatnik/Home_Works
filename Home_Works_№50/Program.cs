/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

int[,] array = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
System.Console.WriteLine("Введите позицию элемента: ");
int Number = int.Parse(Console.ReadLine());

bool found = false;
int row = -1;
int col = -1;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == Number)
        {
            row = i;
            col = j;
            found = true;
            break;
        }
    }

    if (found)
    {
        break;
    }
}

if (found)
{
    Console.WriteLine($"Индекс элемента {Number} - [{row}, {col}]");
}
else
{
    Console.WriteLine("Элемент не найден");
}