Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i += 2)
{
    Console.Write(-i);
}