//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введи первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
   Console.WriteLine($"{numberA} больше чем {numberB}");
}
else
{
   Console.WriteLine($"{numberB} больше чем {numberA}");
}
