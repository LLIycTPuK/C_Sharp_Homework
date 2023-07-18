Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);


void PrintArray(double[,] matrix)
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
void FillArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }

    }
}

void Change(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i % 2) != 0 && (j % 2) != 0)
            {
                matrix[i, j] = Math.Pow(matrix[i, j], 2);
            }

        }
    }
}

double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Change(matrix);
PrintArray(matrix);