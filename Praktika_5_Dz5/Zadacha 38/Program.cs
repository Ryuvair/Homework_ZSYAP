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
int MinMax (int[] arr)
{
    int ans = 0;
    int maximum = arr[0];
    int minimum = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {   
        if (maximum < arr[i]) maximum = arr[i];
        if (minimum > arr[i]) minimum = arr[i];      
    }
    ans = maximum - minimum;
    Console.WriteLine($"Максимум = {maximum}");
    Console.WriteLine($"Минимум = {minimum}");
    Console.WriteLine($"{maximum} - {minimum} = {ans}");
    return ans;
}

int[] array = GenerateArray(min, max, length);
PrintArray(array);
MinMax(array);