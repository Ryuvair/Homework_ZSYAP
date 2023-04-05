void DubleMax(int[] array)
{
    int max_1 = 0;
    int max_2 = 0;
    int index = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max_1) 
        {
            max_1 = array[i];
            
        }
    }
  
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max_2 && array[i] < max_1)
        {
            max_2 = array[i];
        }
   
    }
    Console.WriteLine($"Первый максимум: {max_1} | Второй масимум {max_2}");
}

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
int[] numbers = GenerateArray();
PrintArray(numbers);
DubleMax(numbers);