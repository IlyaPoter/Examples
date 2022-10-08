Console.WriteLine("Введите певрое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber == 0)
{
    Console.WriteLine("Error");
}
else
{
    int result = secondNumber / firstNumber;
    if (result == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine(result);
    }
}
