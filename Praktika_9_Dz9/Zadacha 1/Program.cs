/* Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные 
числа в промежутке от m до N . Выполнить с помощью рекурсии. */

void RecSumEven(int N, int M)
{
    if (N >= M) return ;
    if (N % 2 == 0 && N != 0)
    {
        Console.Write($"{N} ");
    }
    RecSumEven(N + 1, M);
}

Console.WriteLine("Введите число от которого начинается отсчет");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число до которого идет отсчет");
int m = int.Parse(Console.ReadLine());
RecSumEven(n,m);