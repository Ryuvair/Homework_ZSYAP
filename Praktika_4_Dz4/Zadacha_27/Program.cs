// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfDigits (int arg)
{ 
    int count = 0; // переменная для поиска последней цифры числа 
    int temp = 0; // контейнер для суммы цмфр числа
    int i = 1;
    while (arg > 0)
    {
        count = arg % 10;   // Поиск последней цифры в числе с шагом один
        arg = arg / 10; // уменьшение самого числа на десятую часть до 0,9
        
        temp = temp + count ; // Посчет всех цифр числа начиная с права на лево
        
        Console.WriteLine(" ");
        Console.Write("Число с конца №");
        Console.Write(i);
        Console.Write(" : ");
        Console.Write(count);
        i++; // счетчик номера числа с конца
    }
    Console.WriteLine(" ");
    Console.Write("Сумма всех цифр в числе = ");
    Console.Write(temp);

}


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

SumOfDigits(number);
