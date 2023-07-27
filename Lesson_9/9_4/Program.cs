Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);


int PrintNumber(int num, int step)
{
    if (step == 0) return 1;

    return PrintNumber(num, step-1) * num;
}

Console.WriteLine(PrintNumber(a,b));

