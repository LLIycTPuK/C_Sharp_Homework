//123 % 10 -> 3
//123 % 100 ->23

// 123 / 10 ->12
//123 / 100 ->1
Console.WriteLine("Введите пятизначное число для проверки является ли оно палиндромом: ");
int num = int.Parse(Console.ReadLine()!);
int a = num / 10000;
int b = num / 1000 - num / 10000 * 10;
int c = (num % 100 - num%10) /10 ;
int d = num%10;
if (a == d && b == c)
Console.WriteLine("Число является палиндромом");
else
Console.WriteLine("Число не является палиндромом");
