Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение: ");
int b = int.Parse(Console.ReadLine()!);

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 8}");
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
            matrix[i, j] = new Random().NextDouble() * (b - a) + a;
            matrix[i, j] = Math.Round(matrix[i, j], 2);

        }

    }
}
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);