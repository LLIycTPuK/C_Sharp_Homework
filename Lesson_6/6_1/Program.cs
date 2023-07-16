Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine()!);

bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < c + a && c < b + a)
        return true;
    else
        return false;
}

Console.WriteLine(Triangle(a, b, c));