// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GenerateArray(int Length, int Max, int Min)
{       
    
    int[] array = new int [Length]; 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
{
        array[i] = random.Next(Min, Max + 1);
}
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length ; i++)
    {
        //Console.Write("№");
        //Console.Write($"{i+1}:");
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
Console.WriteLine("Введдите максимальное значение диапазона случаных чисел которые заполнят массив");
    int max = int.Parse(Console.ReadLine());
    Console.WriteLine("Введдите минимальное значение диапазона случаных чисел которые заполнят массив");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите колличество элементов массива");
    int length = int.Parse(Console.ReadLine());
int[] array = GenerateArray(length,max,min);
PrintArray(array);
