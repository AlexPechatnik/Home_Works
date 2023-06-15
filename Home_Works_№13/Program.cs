//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = 0;
while (a != 0)
{
    b = (b * 10) + (a % 10);
    a = a / 10;
}
Console.WriteLine(b);
