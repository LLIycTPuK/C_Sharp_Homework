Console.WriteLine("Введите диапазон рандомных чисел, max: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine("                                  min: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество чисел в массиве: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, для проверки его нахождения в массиве: ");
int b = int.Parse(Console.ReadLine()!);
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

string CheckNum(int[] arr, int ch)
{
    for (int i = 0; i < array.Length; i++)

        if (arr[i] == ch)
            return "да";
    return "нет";
}

FillArray(array);
PrintArray(array);
Console.WriteLine(CheckNum(array, b));
