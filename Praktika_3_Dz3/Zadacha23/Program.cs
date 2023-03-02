//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int SearchForCube(int arg)
{
    double ans = 0;

    for (int i = 1; i <= arg; i++)
    {
        ans = Math.Pow(i,3);
        Console.Write(i);
        Console.Write(" В кубе : ");
        Console.WriteLine (ans);
    }
return 0 ;
}

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());

SearchForCube(N);