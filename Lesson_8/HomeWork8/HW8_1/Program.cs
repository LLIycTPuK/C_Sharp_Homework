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

void Sort(int[,] matrix)
{
    int temp;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            for (int c = j + 1; c < n; c++)
            {
                if (matrix[i, j] > matrix[i, c])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, c];
                    matrix[i, c] = temp;
                }
            }
        }
    }

}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Sort(matrix);
PrintArray(matrix);