// Напишите программу, которая принимает на вход чило и выдает сумму цифр в числе.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = 0;
while (number > 0)
{
    result += number % 10;
    number = number /10;
}

Console.WriteLine(result);
