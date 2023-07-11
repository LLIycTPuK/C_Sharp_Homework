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
        collection[index] = new Random().Next(min, max + 1);
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


int[] NewArray(int[] arr)
{
    int lengthnew = arr.Length;
    int[] arr_2;
    if (lengthnew % 2 == 0)
    {
        arr_2 = new int[lengthnew / 2];
    }
    else arr_2 = new int[lengthnew / 2 + 1];

    for (int i = 0; i < arr_2.Length; i++)
    {
        if (arr[i] != arr[lengthnew - i - 1])
            arr_2[i] = arr[i] * arr[lengthnew - i - 1];
        else arr_2[arr_2.Length - 1] = arr[i];
    }
    return arr_2;
}



FillArray(array);
PrintArray(array);
Console.WriteLine("");
int[] array_2 = NewArray(array);
PrintArray(array_2);
