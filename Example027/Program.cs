// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибонначи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int number = GetNumber();
int[] fib = new int[number];
Fib(fib);
WriteArray(fib);
int GetNumber()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] Fib(int[] fib)
{
    for (int i = 2; i < fib.Length; i++)
    {
        fib[1] = 1;
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}