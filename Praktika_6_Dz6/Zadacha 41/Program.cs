int[] GenerateArray ()
{
    Console.WriteLine("Введите колличество элементов");
    int length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        Console.WriteLine($"Число №{i+1} : ");
        array[i] = int.Parse(Console.ReadLine());

    }
    Console.WriteLine(" ");
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
void Find(int[] arr)
{
    int k = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) k++;
    }
    Console.WriteLine($"Вы ввели {k} элемента больше нуля");
}
int[] array = GenerateArray();
PrintArray(array);
Find(array);