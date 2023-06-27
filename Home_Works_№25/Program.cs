// Напишите программу, которая принимает на вход два числа А и В, и возводит число А в натуральную степень В.
Console.WriteLine("Введите число А");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int num2 = int.Parse(Console.ReadLine());
int i = 0;
int result = 1;

while (num2 >= i)
{
    result = num1*num1;
    i++;
}
Console.WriteLine(result);

