/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив: */

void PrintArray(int[,] mtrx)
{
    Console.WriteLine(" ");
    Console.WriteLine("Матрица ");
    Console.WriteLine(" ");

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
void FillArraay(int[,] mtrx)

{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {

        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] =  new Random().Next(10, 100) ; 
        }
    }
}
void Uporyad(int[,] mtrx)
{
    int temp;
    for (int k = 0; k < mtrx.GetLength(0); k++)
    {
        for (int i = 0; i < mtrx.GetLength(1); i++)
        {
        
            for(int j = 0; j <mtrx.GetLength(1) - 1 ; j++)
            {
                if(mtrx[k, j] < mtrx[k, (j + 1)])
                {
                temp = mtrx[k,j];
                mtrx[k,j] = mtrx[k, j + 1];
                mtrx[k, j + 1] = temp;
                }
            }
        }
    }    
}

void Uporyad2(int[,] mtrx)
{
    int temp = 0; 
    for(int k = 0; k < mtrx.GetLength(1) ; k++)
    {
        for(int i = 0; i < mtrx.GetLength(0); i++)
        {
            
            for(int j = 0; j < mtrx.GetLength(0) -1 ; j++)
            {
                if (mtrx[j, k] < mtrx[j + 1, k])
                {
                    temp = mtrx[j, k];
                    mtrx[j, k] = mtrx[j + 1, k];
                    mtrx[j + 1 , k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов ");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,m];

FillArraay(matrix);
PrintArray(matrix);
Uporyad(matrix);
PrintArray(matrix);