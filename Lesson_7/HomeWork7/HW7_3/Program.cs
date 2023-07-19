Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);



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

void Sum(int[,] matrix)
{

    double result = 0;
    double c = 0;
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            result += matrix[i, j];


        }
        c = Math.Round(result / n, 1);
        Console.Write($"{c}; ");
        result=0;

    }
}
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Sum(matrix);