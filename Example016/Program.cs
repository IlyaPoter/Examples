Console.Clear();
Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Является");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Является");
//     return;
// }
// if (number2 == number1 * number1)
// {
//     Console.WriteLine("Является");
//     return;
// }
// Console.WriteLine("Не является");
