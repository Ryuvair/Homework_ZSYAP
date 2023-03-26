void FillArraay(int[,] mtrx)

{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {

        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = new Random().Next(1, 10) ;
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

void Sred(int[,] mtrx)

{   
    double ans = 0;
    for(int j = 0; j < mtrx.GetLength(1); j++)
    {
        ans = 0;
        for (int i = 0; i < mtrx.GetLength(0) ; i++)
        {
            ans = mtrx[i,j] + ans; 
        }    
        ans = (ans / mtrx.GetLength(0));
        Console.WriteLine($"Среднее арефметическое столбца №{j+1} = {ans}");
    }
}



Console.WriteLine("Введите кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов ");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,m];

FillArraay(matrix);
PrintArray(matrix);
Sred(matrix);