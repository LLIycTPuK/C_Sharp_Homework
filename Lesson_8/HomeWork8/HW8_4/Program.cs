Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число: ");
int b = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
int[] indexes = new int[2];

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

int[] Find(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int min_num = matrix[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (min_num > matrix[i, j])
            {
                min_num = matrix[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }

        }

    }
    Console.WriteLine(matrix[indexes[0], indexes[1]]);
    return indexes;
    /*for (int i = 0; i < m - 1; i++)
    {
        if (matrix[i, j] < min[min_m, min_n])
            min[min_m, min_n] = matrix[i, j];
    }*/
}


void PrintNewArray(int[,] matrix, int[] indexes)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (indexes[0] == i || indexes[1] == j) continue;
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);
Find(matrix);
PrintNewArray(matrix, indexes);