Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine()!);
double result = 1;
Console.WriteLine("Введите степень: ");
int b= int.Parse(Console.ReadLine()!);
void PowTable(double num)
{
        for (int i = 1; i <= b; i++)
        {
            result = result*a;
            
        }
        Console.Write($"{result}");
}
PowTable(a);