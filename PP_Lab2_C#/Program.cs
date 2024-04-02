Console.WriteLine("Введите число x (x!=0): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число шагов  n (n > 0): ");
int n = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(x) > 1 && n > 0)
{
    double result = 0;
    for(int i = 0; i < n; i++)
    {
        result += 1 / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не корректные данные");
}

