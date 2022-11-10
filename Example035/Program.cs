// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] selectArray = SelectArray(array);

int[,] SelectArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            for (int k = z + 1; k < array.GetLength(1) - 1; k++)
            {
                int maxNumber = array[j, z];
                if (maxNumber > array[j, z + k])
                {
                    maxNumber = array[j, z + k];
                    array[j, z + k] = array[j, z];
                    array[j, z] = maxNumber;
                }
                else
                {
                    maxNumber = array[j, z + k];
                }
            }
        }
    }
    return array;
}

    void PrintArraySelect(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();

    PrintArraySelect(selectArray);
