// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования



void Main()
{
    Console.Clear();
    int[] arr = { 1, 2, 3, 4, 5 };
    int[] CopyArray = GetArrCopy(arr);
    WriteArray(CopyArray);
}

int[] GetArrCopy(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Main();