Console.WriteLine("введите число и проверьте ли оно кратно одновременно 7 и 23");

void Crat(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}
int NumA = int.Parse(Console.ReadLine()!);
Crat(NumA);