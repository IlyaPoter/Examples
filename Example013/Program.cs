int num = new Random().Next(100, 1000);

int firstSymbol = num / 100;
int lastSymbol = num % 10;

Console.WriteLine($"Число {num} стало {firstSymbol}{lastSymbol}");
