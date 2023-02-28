int Max(int arg1, int arg2)
{
    int max = arg1;
    if (arg1 == arg2)
    {
        Console.WriteLine("Числа равны");
    }
    if (arg2 > arg1)
    {
         max = arg2;
    }
    Console.Write("Макчимальное число = ");
    Console.WriteLine(max);
    return max;
}

int a = new Random().Next(1,1000);

int b = new Random().Next(1,1000);

Max(a,b);