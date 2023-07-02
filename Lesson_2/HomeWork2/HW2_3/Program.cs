//123 % 10 -> 3
//123 % 100 ->23

// 123 / 10 ->12
//123 / 100 ->1
Console.WriteLine("ВВедите любое число и увидите третью цифру этого число: ");
int TakeNum(int num)
{
    int result = -1
    if (num > 99 && num < 1000)
       int result = num % 10;
     while (num >= 1000)
    {

         num =num / 10
    }
        result = number%10;

    else
        result = -1;
}


int thd_num = int.Parse(Console.ReadLine()!);
TakeNum(thd_num);
if (TakeNum(thd_num) == -1)
Console.WriteLine("третьей цифры нет");
else Console.WriteLine(TakeNum(thd_num); 
