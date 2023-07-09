double VectorLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+Math.Pow(z2-z1, 2));
}
Console.WriteLine("Введите координату х1: ");
int x1 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату у1: ");
int y1 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z1: ");
int z1 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату х2: ");
int x2 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату у2: ");
int y2 =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z2: ");
int z2 =int.Parse(Console.ReadLine()!);

double result = VectorLenght(x1, y1, z1, x2, y2, z2 );
Console.WriteLine("Расстояние между точками= "+ result);