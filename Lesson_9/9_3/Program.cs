Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);


int PrintNumber(int num)
{
    if (num / 10 == 0)
    {
        return num;
    }
    return PrintNumber(num / 10) + num % 10;
}

Console.WriteLine(PrintNumber(a));
