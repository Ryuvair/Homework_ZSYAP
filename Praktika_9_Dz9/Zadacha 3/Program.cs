int Akkerman(int N,int M)
{
    if (N == 0)
    {
        Console.WriteLine($"({N},{M + 1})");
        return M +1;
    }
    if (N != 0 && M == 0)
    {
        return Akkerman(N - 1, 1);
    }
    if ( N > 0 && M > 0)
    {
        return Akkerman(N -1, Akkerman(N, M -1));
    }
    return 0;
}



Console.WriteLine("Введите первое число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(n,m));