Console.WriteLine("Введите номер четверти ");
int num = int.Parse(Console.ReadLine()!);
void Quarters(int x)
{

    if (x < 1 || x > 4)
        Console.WriteLine("нет такой четверти");
    else if (x == 1)
        Console.WriteLine("x > 0 && y > 0");
    else if (x == 2)
        Console.WriteLine("x < 0 && y > 0");
    else if (x == 3)
        Console.WriteLine("x < 0 && y < 0");
    else if (x == 4)
        Console.WriteLine("x > 0 && y < 0");
}
Quarters(num);