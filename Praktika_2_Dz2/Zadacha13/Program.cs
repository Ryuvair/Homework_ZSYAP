//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindTherdDigit(int arg)
{
while (arg > 1000)
{     
    arg = arg / 10;
}

if (arg < 100 )
{
    Console.WriteLine("Третьего числа нет"); 
}

else
{
    int FirstDigit = arg / 100;
    int SecondDigit = arg / 10 - FirstDigit * 10;
    int TherdDigit = arg - FirstDigit * 100  - SecondDigit * 10;

    Console.Write("Третье число : ");
    Console.WriteLine(TherdDigit);
}

return 0;

}
Console.Write("Введите число : ");
int nubmer = int.Parse(Console.ReadLine());




FindTherdDigit(nubmer);