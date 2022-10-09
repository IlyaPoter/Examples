Console.Clear();
Console.WriteLine("Введи Х: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введи Y: ");
int y = int.Parse(Console.ReadLine());
if (x>0)
{
    if (y>0)
    {
        Console.WriteLine("1 четверть");
    }
    else
    {
        Console.WriteLine("4 четверь");
    }
}
else
{
    if (y>0)
    {
        Console.WriteLine("2 четверь");
    }
    else
    {
        Console.WriteLine("3 четверть");
    }
}


