
int FactNumber(int n)
{
    if (n == 1) return 1;
    else return n * FactNumber(n - 1);
}

int res = FactNumber(3);
Console.WriteLine(res);



