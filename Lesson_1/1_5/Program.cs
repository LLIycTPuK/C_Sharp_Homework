
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = -a;
    Console.WriteLine(count);
while (count!=a)
{
    if (a>0)
    count++; // count = count + 1
    else
    count--; // count = count - 1
    Console.WriteLine(count);
}