//123 % 10 -> 3
//123 % 100 ->23

// 123 / 10 ->12
//123 / 100 ->1

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;

}
/* int TakeNum2(int num)
{
    return num / 100;

} */


int last_num = new Random().Next(100, 1000);
int result = TakeNum(last_num);
int result2 = last_num / 100;
Console.WriteLine($"{result2}{result}");