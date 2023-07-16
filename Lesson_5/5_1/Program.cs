Console.WriteLine("Введите диапазон рандомных чисел, max: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine("                                  min: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество чисел в массиве: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
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
        Console.Write(col[position] + " ");
        position++;
    }
}

void SumNegPos(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)

        arr[i] *= -1;
}

FillArray(array);
PrintArray(array);
SumNegPos(array);
Console.WriteLine("");
PrintArray(array);