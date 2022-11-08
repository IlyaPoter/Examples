// Задайте двумерный массив. Найдите элементы, у которых оба индекса четный и замените эти элементы на их квадраты

Console.Clear();

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array1 = NewArray(rows, columns);
PrintArray(array1);
Console.WriteLine();
int[,] finishArray = GetArray(array1, rows, columns);

PrintArray(finishArray);

int[,] NewArray(int m, int n)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

int[,] GetArray(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}