int Chisla(string numbers)
{
    Console.Write(numbers);
    string value = Console.ReadLine()!;
    int num = Convert.ToInt32(value);
    return num;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Chisla($"Введите{i + 1}-й элемент");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }

    }
    return count;
}

int[] array;
int length = Chisla("Введите кол-во элементов: ");
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во чисел больше 0 ={Count(array)}");