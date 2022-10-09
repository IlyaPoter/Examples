Console.Clear();
Console.WriteLine("Введите координату Х первого числа: ");
int oneX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первого числа: ");
int oneY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Х второго числа: ");
int twoX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второго числа: ");
int twoY = int.Parse(Console.ReadLine());
int differentX = oneX - twoX;
int differentY = oneY - twoY;
double result = Math.Sqrt((differentX * differentX + differentY * differentY));
Console.WriteLine(result);



