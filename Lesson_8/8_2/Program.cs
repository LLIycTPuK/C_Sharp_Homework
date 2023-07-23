Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число: ");
int b = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];



void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(a, b);
        }

    }
}
int[] frequency(int[,] matrix)
{
    int[] friq = new int[b + 1];
    foreach (int i in matrix)
    {
        friq[i] += 1;

    }
    return friq;
}

void PrintMass(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"цифр {i} = {array[i]} в матрице");
    }
}


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[] result = frequency(matrix);
PrintMass(result);