// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
//  Array.Sort(mas);
//  Array.Reverse(mas);
/*
Console.Write("ВВедите количество строк массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите количество столбцов массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

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

void DescendingArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
        }
    }
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("===========");

// сортируем массив
int min = matrix[0, 0];
int exchange = min;

static void SortMethod(int m, int n, int[,] matrix, int min, int exchange)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            min = matrix[i, j];
            for (int k = j + 1; k < m; k++)
            {
                if(matrix[i, k] > min)
                {
                    exchange = min;
                    min = matrix[i, k];
                    matrix[i, k] = exchange;
                }
            }
            matrix[i, j] = min;
        }
    }
}

SortMethod(m, n, matrix, min, exchange);
PrintArray(matrix);
