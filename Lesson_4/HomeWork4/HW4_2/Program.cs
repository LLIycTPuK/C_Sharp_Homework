Console.WriteLine("Введите число: ");
int result=0;
int Sum(int num)
{
while (num>0)
{
    result= result + num%10;
    num=num/10;
}
return result;
}
int a=int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(a));

/*int result = 0;

void ArraySum(int[] n)
{
    string str = n.ToString();
    for (int position = 0; position < str.Length; position++)
    {
        result +=  str[position];
        
    }
    }

int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(ArraySum(a));
не взлетело :*(
    */


