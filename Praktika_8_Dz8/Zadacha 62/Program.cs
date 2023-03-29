int[,] array = new int[4, 4];

for(int k = 0; k < array.GetLength(0); k++)
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; i < array.GetLength(1); i++)
    {
        if(j < array.GetLength(1) )
        {
        array[j, k] = int.Parse(Console.ReadLine);
        }
        if(i < array.GetLength(0)  && j == array.GetLength(1) )
        {
            array[i,j] = int.Parse(Console.ReadLine);
        }
        if()
    }
}
