void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}



void Copy(int[,] matr)
{
    int c = 0;
    int d = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            c = i;
            d = j;

            Console.Write($"{matr[c, d]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите кол-во цифр в массиве: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк в массиве");
int a = int.Parse(Console.ReadLine()!);
int[,] array = new int[a, b];


FillArray(array);
PrintArray(array);
Console.WriteLine("");
Copy(array);
