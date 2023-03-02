//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Ведите трехзначное число число : ");

int Digit(int arg)
{

 while ( arg  < 100 || arg > 1000) 
{
    Console.WriteLine("Вы ввели не коректное число введите заного");
    Console.Write("Ведите трехзначное число  : ");
    nubmer = int.Parse(Console.ReadLine());
    arg = nubmer;     
}
   

int FirstDigit = arg / 100;

int SecondDigit = arg / 10 - FirstDigit * 10;

int TherdDigit = arg - FirstDigit * 100  - SecondDigit * 10;

Console.Write("Первое число : ");
Console.WriteLine(FirstDigit);

Console.Write("Второе число : ");
Console.WriteLine(SecondDigit);

Console.Write("Третье число : ");
Console.WriteLine(TherdDigit);

return 0;

    }
int nubmer = int.Parse(Console.ReadLine());

Digit(nubmer);

