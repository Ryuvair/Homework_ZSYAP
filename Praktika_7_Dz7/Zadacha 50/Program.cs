void FillArraay(int[,] mtrx)

{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {

        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = new Random().Next(1, 100) ;
        }
    }

}
void PrintArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j]} ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}

void Find(int[,] mtrx, int arg)
{
    int k = 0;
    for(int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i,j] == arg) 
            {
                Console.WriteLine($"Число({arg}) находиться на позициях : {i+1}:{j+1} ");
                k++;
            }
            

        }
    }
    if(k > 0) Console.WriteLine($"Число({arg}) встретилость в колличестве : {k}"); 
    if (k == 0) Console.WriteLine($"Число({arg}) не было найдено");
}   



Console.WriteLine("Введите кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число которые хотите найти в масиве : ");
int x = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,m];

FillArraay(matrix);
PrintArray(matrix);
Find(matrix,x);