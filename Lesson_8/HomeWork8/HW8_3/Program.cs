
Console.WriteLine("Введите минимальное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число: ");
int b = int.Parse(Console.ReadLine()!);
int m = 2;
int n = 2;

int[,] matrix = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] result = new int[m, n];


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
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            matrix[i, j] = new Random().Next(a, b);
        }

    }
}
/*void Mult(int[,] result)
{

result[0,0] = ;
}*/
void Multiplication(int[,] result)
{
    int[,] r = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                r[i, j] += matrix[i, k] * matrix2[k, j];
            }
            Console.Write($"{r[i,j],4}"+" ");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
Multiplication(result);
//PrintArray(result);