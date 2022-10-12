// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
int result = 1;
int Multi(int number)
{
    for (int count = 1; count <= number; count++)
    {
        result = result * count;
    }
    return result;
}
Console.WriteLine(Multi(num));
