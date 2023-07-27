Console.WriteLine("Введите число начала промежутка : ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число конца промежутка : ");
int b = int.Parse(Console.ReadLine()!);

void PrintNumber(int num, int num2)
{
    if (num < num2)
    {
        return;
    }
    PrintNumber(num - 1, num2);

    Console.Write($"{num} ");

}

PrintNumber(b,a);