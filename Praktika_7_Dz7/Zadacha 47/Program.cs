void FillArraay(double[,] mtrx)

{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {

        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = Math.Round((new Random().NextDouble() * 100) ,3);
        }
    }

}

void PrintArray(double[,] mtrx)
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

Console.WriteLine("Введите кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов ");
int m = int.Parse(Console.ReadLine());;
double[,] matrix = new double[n,m];

PrintArray(matrix);
FillArraay(matrix);
PrintArray(matrix);