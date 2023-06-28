Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 0;
while (count < a)
{
    Console.Write(count);
    count++; // count = count + 1
}