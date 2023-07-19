Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию искомого числа в столбце: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию искомого числа в строке: ");
int b = int.Parse(Console.ReadLine()!);


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
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
            matrix[i, j] = new Random().Next(1, 10);
        }

    }
}

string Search(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i + 1 == a && j + 1 == b)
                return $"{matrix[i, j]}";
        }
    }
    return "Такого числа в массиве нет";
}

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(Search(matrix));
