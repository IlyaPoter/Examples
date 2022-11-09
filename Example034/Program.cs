// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] SelectArray(int[,] array, int n, int m)
{
    int[] tempArray = new int[n];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tempArray[i] = array[0, i];
    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = array[m - 1, j];
    }

    for (int k = 0; k < array.GetLength(1); k++)
    {
        array[m - 1, k] = tempArray[k];
    }
    return array;
}



// int[] SelectArray(int[,] array, int n)
// {
//     int[] tempArray = new int[n];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         tempArray[i] = array[0,i];
//     }

// return tempArray;
// }

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

int[,] tempArray = SelectArray(array, columns, rows);

void PrinttempArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
}
Console.WriteLine();

//PrinttempArray(tempArray);
PrintArraySelect(tempArray);