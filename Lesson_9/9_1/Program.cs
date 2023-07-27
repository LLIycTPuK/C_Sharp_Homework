Console.WriteLine("Введите число, которе нужно разложить: ");
int a = int.Parse(Console.ReadLine()!);


void PrintNumber(int num)
{
    if (num == 0)
    {
        return;
    }
    PrintNumber(num - 1);

    Console.Write($"{num} ");

}

PrintNumber(a);