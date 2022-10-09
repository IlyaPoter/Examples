Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int qurd= int.Parse(Console.ReadLine());
if (qurd==1)
{
    Console.WriteLine("X>0 and Y>0");
}
if (qurd==2)
{
    Console.WriteLine("X<0 and Y>0");
}
if (qurd==3)
{
    Console.WriteLine("X<0 and Y<0");
}
if (qurd==4)
{
    Console.WriteLine("X>0 and Y<0");
}
else
{
    Console.WriteLine("Не корректно введена четверь");
}