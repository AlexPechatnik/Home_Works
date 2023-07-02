/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int[] array = new int[5];

Console.WriteLine("Введите певое число ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четветртое число ");
int num4 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число ");
int num5 = int.Parse(Console.ReadLine());

array[1] = num1;
array[2] = num2;
array[3] = num3;
array[4] = num4;
array[5] = num5;

int m = 0;

for (int i = 0; i < 5; i++)
{
    if (array[i] > 0)
    {
        m++;
    }
}
Console.WriteLine(m);