//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int result = 0;

if (a <= 99)
{
    Console.WriteLine("третьей цифры нет");
    return;
}

if (a >= 1000)
{
    result = (a / 100) %10;
    Console.WriteLine(result);
    return;
}
if (a <= 999)
{
    result = a % 10;
    Console.WriteLine(result);
    return;
}


Console.WriteLine(result);
