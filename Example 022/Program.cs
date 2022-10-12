// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = 0;

int Numbers(int number)
{
    for (result = 0; number>0; result++)
    {
        number = number / 10;
    }

    // while (number > 0)
    // {
    //     number = number / 10;
    //     result++;
    // }
    return result;
}
Console.WriteLine(Numbers(num));
