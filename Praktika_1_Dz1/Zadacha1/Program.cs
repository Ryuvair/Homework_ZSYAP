int Max(int arg1, int arg2)
{
    int max = arg1;
    int min = arg2;
    if (arg1 == arg2)
    {
        Console.WriteLine("Числа равны");
    }
    if (arg2 > arg1)
    {
         max = arg2;
         min = arg1;
         
    }
    Console.Write("Макcимальное число = ");
    Console.WriteLine(max);
    Console.Write("Минимальное число = ");
    Console.WriteLine(min);
    return max;
}
void Print(int arg1, int arg2)

{
    Console.Write("Первое число = ");
    Console.WriteLine(arg1);
     Console.Write("Второе число = ");
    Console.WriteLine(arg2);
}

int a = new Random().Next(1,1000);
int b = new Random().Next(1,1000);

Print(a,b);
Max(a,b);
