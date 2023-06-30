//123 % 10 -> 3
//123 % 100 ->23

// 123 / 10 ->12
//123 / 100 ->1

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 100;

}



int twolast_num = new Random().Next(100, 1000);
int result = TakeNum(twolast_num);
Console.WriteLine(result / 10);