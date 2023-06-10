// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите первое число ");
int numB = int.Parse(Console.ReadLine());

Console.Write("Введите первое число ");
int numC = int.Parse(Console.ReadLine());
// Нашел оператор сравнивания 2 числе(Math.Max) в GPTchat, им там же можно сравнить и 3 числа. 
int max = Math.Max(Math.Max(numA, numB),numC);

Console.WriteLine("Самое большое число = " +max);