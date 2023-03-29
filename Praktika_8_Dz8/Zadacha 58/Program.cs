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
            mtrx[i,j] =  new Random().Next(1, 10) ; 
        }
    }
}

int[,] ProductTwoMatrices(int[,] mtrxA, int[,] mtrxB)/* , int  columsA, int columsB, int rowsA, int rowsB */
{
    if (mtrxA.GetLength(1) != mtrxB.GetLength(0))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
    int[,] matrixC = new int[mtrxB.GetLength(0),mtrxA.GetLength(1)]; 
    for (int i = 0; i < mtrxA.GetLength(0); i++ )
    {
        for (int j = 0; j < mtrxB.GetLength(1); j++)
        {
            matrixC[i,j] = 0;
            for ( int k = 0; k < mtrxA.GetLength(1); k++)
            {
                matrixC[i, j] += mtrxA[i, k] * mtrxB[k, j];
            }
        }
    }
    return matrixC;
}

Console.WriteLine("Введите кол-во строк первой матрицы ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов первой матрицы ");
int m = int.Parse(Console.ReadLine());
int[,] matrixA = new int[n,m];

Console.WriteLine("Введите кол-во строк Второй матрицы ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов Второй матрицы ");
int m2 = int.Parse(Console.ReadLine());
int[,] matrixB = new int[n,m];

Console.WriteLine("Первая матрица");
FillArraay(matrixA);
PrintArray(matrixA);

Console.WriteLine("Вторая матрица");
FillArraay(matrixB);
PrintArray(matrixB);

int[,] ans = ProductTwoMatrices(matrixA,matrixB);
PrintArray(ans);
