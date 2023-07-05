double VectorLenght(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}
Console.WriteLine("Введите координату х1: ");
int x1 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату у1: ");
int y1 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату х2: ");
int x2 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату у2: ");
int y2 =int.Parse(Console.ReadLine()!);

double result = VectorLenght(x1, y1, x2, y2);
Console.WriteLine("Расстояние между точками= "+ result);