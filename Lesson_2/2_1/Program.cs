int Max(int num)
{
    if (num/10 > num % 10)
    return num/10;

    return num % 10;
}
int Rnum =  new Random().Next(10, 100);
Console.WriteLine(Rnum);
int result = Max(Rnum);
Console.WriteLine(result);