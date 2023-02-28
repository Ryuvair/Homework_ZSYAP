int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if ( arg1 == arg2 & arg3 == arg2 )
    {
        Console.WriteLine("Числа равны");
    }
    if (arg2 > arg1)
    {
         max = arg2;
    }
    if (arg3 > max)
    {
        max = arg3;
    }
    Console.Write("Макcимальное число = ");
    Console.WriteLine(max);
    return max;
}
void Print(int arg1, int arg2, int arg3)
{
    Console.Write("Первое число = ");
    Console.WriteLine(arg1);
     Console.Write("Второе число = ");
    Console.WriteLine(arg2);
     Console.Write("Третие число = ");
    Console.WriteLine(arg3);
}
int a = new Random().Next(1,1000);

int b = new Random().Next(1,1000);

int c = new Random().Next(1,1000);

Print(a,b,c);
Max(a,b,c);