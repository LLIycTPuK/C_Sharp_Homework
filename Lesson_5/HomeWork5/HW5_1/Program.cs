
Console.WriteLine("Введите количество чисел в массиве: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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


int EvenNum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            result ++;
    }
    return result;
}



FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(EvenNum(array));


