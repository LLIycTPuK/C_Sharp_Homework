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

int CheckNum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)

        if (arr[i] > 10 && arr[i] < 100)
            result++;
    return result;

}

FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(CheckNum(array));
