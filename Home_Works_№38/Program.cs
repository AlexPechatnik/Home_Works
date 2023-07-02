/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
double[] array = new double[10];
double[] RoundArray = new double[array.Length];

Console.WriteLine("Массив заполненный случайными числами: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    RoundArray[i] = Math.Round(array[i], 2);
    Console.Write($"{RoundArray[i]}  ");
    if (max < RoundArray[i])
    {
        max = RoundArray[i];
    }
}
double sum = 0;
double max = RoundArray[0];
double min = RoundArray[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < RoundArray[i])
    {
        max = RoundArray[i];
    }

     if (min >= RoundArray[i])
    {
        min = RoundArray[i];
    }
}
Console.WriteLine("");
Console.WriteLine($"Максимальное значение: {max}  ");
Console.WriteLine($"Минимальное значение: {min}  ");

