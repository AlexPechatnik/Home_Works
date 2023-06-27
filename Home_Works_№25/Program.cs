// Напишите программу, которая принимает на вход два числа А и В, и возводит число А в натуральную степень В.
Console.WriteLine("Введите число А");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int num2 = int.Parse(Console.ReadLine());


int i = 1;
int result = num1;

while (num2 > i)
{
    result = result*num1;
    i++;
}
Console.WriteLine(result);

