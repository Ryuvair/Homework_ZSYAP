
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int PalindromeFiveDigitCheck(int arg)
{
    while ( arg  <= 10000 || arg >= 100000) 
{
    Console.WriteLine("Вы ввели не коректное число введите заного");
    Console.Write("Ведите пятизначное число  : ");
    arg = int.Parse(Console.ReadLine());
    //arg = fivedigit;     
}

    int FirstDigit = arg / 10000;
    int SecondDigit = arg / 1000 - FirstDigit * 10;
    int FivthDigit = arg % 10;
    int FourthDigit = (arg % 100 - FivthDigit) / 10;

    Console.Write("Первое число : ");
    Console.WriteLine(FirstDigit);

    Console.Write("Второе число : ");
    Console.WriteLine(SecondDigit);

    Console.Write("Четвертое число : ");
    Console.WriteLine(FourthDigit);

    Console.Write("Пятое число : ");
    Console.WriteLine(FivthDigit);
    
    Console.WriteLine("                                  ");
    Console.WriteLine("                                  ");
    
  
    if (FirstDigit == FivthDigit & FourthDigit == FourthDigit)
    {
        Console.Write("Число : ");
        Console.Write(arg);
        Console.WriteLine(" Является палиндромом");

    }
    else
    {
        Console.Write("Число : ");
        Console.Write(arg);
        Console.WriteLine(" Не Является палиндромом");
    }
    return 0;
}


Console.Write("Веддите пятизначное число : ");
int fivedigit = int.Parse(Console.ReadLine());

PalindromeFiveDigitCheck(fivedigit);