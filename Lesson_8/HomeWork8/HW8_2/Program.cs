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
void Sum(int[,] matrix)
{
    int result = 0;
    int[] sum = new int[m ];
    if (m == n)
    {
        Console.WriteLine();
        Console.WriteLine("массив не прямоугольный");
    }
    else

    {

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum[i] += matrix[i, j];

            }
            Console.WriteLine($"{sum[i]}");
        }
        for (int i = 0; i < m-1; i++)
        {
            if (sum[i] <= sum[i + 1])
                result = i;
        }
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result+1} строка.");
    }

}

FillArray(matrix);
PrintArray(matrix);
Sum(matrix);