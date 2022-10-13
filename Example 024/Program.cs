// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

Console.Clear();

int[] array = new int[8];

void MethodArray(int[] newarray)
{
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = new Random().Next(0,2);
        Console.Write($"{newarray[i]} ");
    }
}

MethodArray(array);