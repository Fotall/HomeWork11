/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
static string PrintGood3DInt(int[,,] array, int interval)
{
    string output = String.Empty; //Создали пустую строку
    int size0 = array.GetLength(0);
    int size1 = array.GetLength(1);
    int size2 = array.GetLength(2);
    for (int k = 0; k < size0; k++)
    {
        for (int i = 0; i < size1; i++)
        {
            for (int j = 0; j < size2; j++)
                output += $"{array[k, i, j]}({k},{i},{j}){string.Concat(Enumerable.Repeat("\t", interval))}";
            output += "\n";//Перенос строки массива
        }
        output += "\n\n";//Отступ между слоями
    }
    return output;
}

static int Input(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

bool debug = false;
int columnsInArray = 89;
int listsInArray = 89;
// 0. Метод ввода размерности двумерного массива от пользователя
Console.Write("Введите количество строк массива (общая размерность массива arr[K, M, N] KxMxN не должен превышать 90)): ");
int rowsInArray = Convert.ToInt32(Console.ReadLine());
while (89 / (rowsInArray * columnsInArray) < 1)
{
    columnsInArray = Input($"Введите количество столбцов массива (число должно быть не больше {88 / rowsInArray}): ");
}
while (88 / (rowsInArray * columnsInArray * listsInArray) < 1)
{
    listsInArray = Input($"Введите количество слоёв массива (число должно быть не больше {88 / (rowsInArray * columnsInArray)}): ");
}

static int[,,] CreateArrayInt3D(int K, int M, int N)
    {
        return new int[K, M, N];
    }
    
int[,,] arr3D = CreateArrayInt3D(listsInArray, rowsInArray, columnsInArray);

// 1. Метод заполняет и выводит построчно исходный массив неповторяющимися целыми числами (от 10 до 99)
static void FillRandInt3D(int[,,] array)
{
    int size0 = array.GetLength(0);
    int size1 = array.GetLength(1);
    int size2 = array.GetLength(2);
    int filler = 10;
    int[] singleRowArray;
    static int[] CreateArrayInt(int count)
    {
        return new int[count]; // new int[count];
    }
    singleRowArray = CreateArrayInt(size0 + size1 + size2);
    array[0, 0, 0] = Random.Shared.Next(10, 100);
    singleRowArray[0] = array[0, 0, 0];
    for (int k = 0; k < size0; k++)
    {
        for (int i = 0; i < size1; i++)
        {
            for (int j = 0; j < size2; j++)
            {
                while (Array.Exists(singleRowArray, element => element == filler))
                {
                    filler = Random.Shared.Next(10, 100);
                }
                singleRowArray[k + i + j] = filler;
                array[k, i, j] = filler;
            }
        }
    }
}

FillRandInt3D(arr3D);


Console.WriteLine(PrintGood3DInt(arr3D, 1));