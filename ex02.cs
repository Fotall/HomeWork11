/* 
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
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

FillArray(matrix);
PrintArray(matrix);
int[] sum = new int[n]; 
int min = 0;
int minIndex = 0;

static void SumString(int[] sum, int[,] matrix, int m, int n, int min, int minIndex)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i] = matrix[i, j];
        }
        if(i == 0)
        {
            min = sum[i];
            minIndex = 0;
        }
        else
        {
            if(min < sum[i])
            {
                min = sum[i];
                minIndex = i;
            }
        }
    }
}

SumString(sum, matrix, m, n, min, minIndex);
Console.WriteLine(sum);

