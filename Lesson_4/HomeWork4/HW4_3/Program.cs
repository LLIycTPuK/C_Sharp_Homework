Console.WriteLine("Введите диапазон рандомных чисел, max: ");
int max= int.Parse(Console.ReadLine()!);
Console.WriteLine("                                  min: ");
int min= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество чисел в массиве: ");
void FillArray(int [] collection)
{
int lenght = collection.Length;
int index =0;
while (index < lenght)
{
collection[index] = new Random().Next(min, max);
index++;
}
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}
int a = int.Parse(Console.ReadLine()!);
int[] array = new int [a];
FillArray(array);
PrintArray(array);