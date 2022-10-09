Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
int result = 1;
int index = 1;
while (index <= number)
{
    result = index * index;
    Console.WriteLine(result);
    index++;
}
