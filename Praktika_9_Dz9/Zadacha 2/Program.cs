int Summ(int N, int M)
{
    if(N <= 0) 
    {
        Console.WriteLine($"{N} - является не натуральным числом"); 
        return 0;
    }
    if(M <= 0) 
    {
        Console.WriteLine($"{M} - является не натуральным числом");
        return 0;
    }
    if (N > M) return 0;
    else return N + Summ(N + 1, M);
}




Console.WriteLine("Введите число от которого начинается отсчет");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число до которого идет отсчет");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Cумма всех натуральных чисел от {n} до {m}: {Summ(n,m)}");