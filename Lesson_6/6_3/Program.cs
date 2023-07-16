
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);


void Fibonachi(int N)
{
    int temp = 0;
    int temp2 = 1;

    for (int i = 0; i < N; i++)
    {
        Console.Write(temp+ " ");
        (temp, temp2) = (temp2, temp + temp2);
    }
}

Fibonachi(a);