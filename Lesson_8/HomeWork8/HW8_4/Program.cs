Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число: ");
int b = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
int min_m = 0;
int min_n = 0;


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

void Find(int[,] matrix)
{
    int[,] min = new int[min_m, min_n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] < matrix[i, j + 1])
            {
                min[min_m, min_n] = matrix[i, j];
            }
            Console.WriteLine($"{min[min_m, min_n]}");
        }

    }
    /*for (int i = 0; i < m - 1; i++)
    {
        if (matrix[i, j] < min[min_m, min_n])
            min[min_m, min_n] = matrix[i, j];
    }*/
}


void PrintNewArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == min_m || j == min_n)
            {
                Console.Write("");
            }
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
    }


}
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);
Find(matrix);
PrintNewArray(matrix);