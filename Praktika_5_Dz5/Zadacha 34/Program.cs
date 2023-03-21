// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int Length, int Max, int Min)
{
    int[] array = new int [Length];
    Random random = new Random();
    
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(Min, Max + 1);
    }
    return array;

}
void PrintArray(int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
}
int NumberOfEven(int[] Array)
{
    int k = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] % 2 == 0)  k++;
    }
    Console.Write($"Колличество четны элементов в массиве {k}");
    return k;
}

Console.WriteLine("Введите минимальный диапазон от 100");
int min = int.Parse(Console.ReadLine());
while (min < 99 | min > 999)    // Проаерка 
{
    Console.WriteLine("Введите коректное число !!!! минимальный диапазон от 100");
    min = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите максимальный диапазон до 999");
int max = int.Parse(Console.ReadLine());
while (max < 99 | max > 999)    // Проерка
{
    Console.WriteLine("Введите коректное число !!!! максимальный диапазон до 999");
    max = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введите колличество элементов массива");
int length = int.Parse(Console.ReadLine());


int[] array = GenerateArray(length,max,min);
PrintArray(array);
NumberOfEven(array);