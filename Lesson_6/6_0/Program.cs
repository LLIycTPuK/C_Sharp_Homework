


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
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


void RevMas(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size / 2; i++)
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
}

Console.WriteLine("Введите кол-во цифр в массиве: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];

FillArray(array);
PrintArray(array);
RevMas(array);
Console.WriteLine(" ");
PrintArray(array);
