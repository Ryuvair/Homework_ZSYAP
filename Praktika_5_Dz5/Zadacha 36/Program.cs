Console.WriteLine("Введите минимальный диапазон");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максисмальый диапазон");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число жлементов массива");
int length = int.Parse(Console.ReadLine());

int[] GenerateArray(int Min, int Max, int Length)
{
    int[] array = new int [Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(Min, Max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
}

int SumOfOddElements(int[] Arr)
{
    int sum = 0;
    int count = 0;
    for(int i = 0; i < Arr.Length; i = i + 2)
    {
        count = sum + Arr[i];
        sum = count;
    }
    Console.WriteLine($"Сумма нечетных элементов массива = {sum}");
    return sum;
}
int[] array = GenerateArray(min, max, length);
PrintArray(array);
SumOfOddElements(array);
