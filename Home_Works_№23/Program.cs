// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int i = 1;
int temp = n;
    while (i<=n)
    {
        int result = i*i*i;
        i++;
        Console.Write($"{result}, ");
    }


