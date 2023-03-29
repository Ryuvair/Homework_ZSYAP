int [,,] array = new int[2, 2, 2];
Console.WriteLine(" Введите не вовторяющиеся двухзначные элементы массива ");

for(int k = 0; k < array.GetLength(0); k++)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(2); j++)
        {   
            Console.Write($"{k}:{i}:{j} = ");
            array[k, i, j] = int.Parse(Console.ReadLine());
            Console.Write(" ");
        }
    }
}
Console.WriteLine(" ");
for(int k = 0; k < array.GetLength(0); k++)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(2); j++)
        {   
            Console.Write($"{array[k, i, j]}({k},{i},{j}) ");
        }
        Console.WriteLine(" ");
    }
    
}               