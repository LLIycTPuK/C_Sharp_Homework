Console.WriteLine("Введите диапазон рандомных чисел, max: ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine("                                  min: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество чисел в массиве: ");
int a = int.Parse(Console.ReadLine()!);
double[] array = new double[a];

void FillArray(double[] collection)
{
    
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().NextDouble()*(max - min) + min;
        index++;
    }
}



void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}


double Dif(double[] arr)
{
    double n_min = arr[0];
    double n_max = arr[0];
    double result = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (n_min > arr[i])
            n_min = arr[i];
    }
    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])
            n_max = arr[i];
    }
    result = n_max - n_min;
    return result;
}



FillArray(array);
PrintArray(array);
Console.WriteLine("");
Dif(array);
Console.WriteLine(Dif(array));