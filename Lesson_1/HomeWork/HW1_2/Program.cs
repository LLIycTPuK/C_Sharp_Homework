
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = 0;
if (a > b)
    if(a > c)
    max = a;
    else
    max=c;
else
    if(b > c)
    max=b;
    else
    max = c;
        Console.WriteLine("max="+ max);