Console.WriteLine("Введите трехзначное число ");
int a = int.Parse(Console.ReadLine());
int result = (a % 100)/10;
Console.WriteLine($"Второе число: {result} ");