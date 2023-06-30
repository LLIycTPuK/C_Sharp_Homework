//123 % 10 -> 3
//123 % 100 ->23

// 123 / 10 ->12
//123 / 100 ->1
Console.WriteLine("Введите трехзначное число для отображения его второй цифры");
int TakeNum(int num)
{

    return num % 100;

}



int twolast_num = int.Parse(Console.ReadLine()!);
int result = TakeNum(twolast_num);
Console.WriteLine(result / 10);