Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

string BinaryNumber(int num)
{
    string result = string.Empty;

    for (; num != 0; num /= 2)
    {
        result = num % 2 + result;
    }
    return result;
}

Console.WriteLine(BinaryNumber(a));