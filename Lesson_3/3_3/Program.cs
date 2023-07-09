Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine()!);
double result = 1;
Console.WriteLine("Введите степень: ");
double b = double.Parse(Console.ReadLine()!);
void PowTable(double num)
{
    if (num == 0)
    {
        Console.WriteLine("значение равно 1");
    }
    else
    {
        for (int i = 1; i <= num; i++)
        {
            result = Math.Pow(i, b);
            Console.Write($"{result}" + " ");
        }
    }
}
PowTable(a);
