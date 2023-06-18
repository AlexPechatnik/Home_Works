//Задача 19: Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли 
//оно палиндромом.
Console.WriteLine("Введите 5 значное число:");
int a = int.Parse(Console.ReadLine());
int b = 0;
int c = a;
while (c != 0)
{
    b = (b * 10) + (c % 10);
    c = c / 10;
}

if (b == a)
{
    Console.WriteLine("является палиндромом");
    return;
}

Console.WriteLine("не является палиндромом");

