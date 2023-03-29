//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void MaximumRowAmount(int[,] mtrx, int arg)
{
    int sum = 0;
    int max = 0;
    int[] ans = new int[2];

    for(int row = 0; row < mtrx.GetLength(0); row++)
    {
        for (int colum = 0; colum < mtrx.GetLength(1); colum++)
        {
            sum += mtrx[row, colum]; 
        }
        if (sum > max) 
        {
            ans[0] = sum;
            ans[1] = row + 1; 
            max = sum;
        }
        sum = 0;
        
    }
    Console.WriteLine($"Максимальная сумма строки : {ans[0]} ");
    Console.WriteLine($" Номер строки : {ans[1]}");
}

void MinRowAmount(int[,] mtrx, int arg)
{
    int sum = 0;
    int count = 0;
    int min = 1000*2000;
    int[] ans = new int[2];

    for(int row = 0; row < mtrx.GetLength(0); row++)
    {
        
        for (int colum = 1; colum < mtrx.GetLength(1); colum+=2)
        {
            sum = mtrx[row , colum - 1] + mtrx[row, colum] + sum;
            /* Console.WriteLine($"{row}:{colum}---{sum}"); */
            if(arg  == colum + 2 && arg % 2 == 1)
            {
                colum = colum + 1;  
                ;
                sum = sum + mtrx[row  , colum  ];
                /* Console.WriteLine($"{row}:{colum}---{sum}"); */
            }
        }
        count = sum;
        /* count = sum; */
        sum = 0;

        if (count < min) 
        {
            ans[0] = count;
            ans[1] = row + 1; 
            min = count;
        }
        
    }
    Console.WriteLine($"Минимальная сумма строки : {ans[0]} ");
    Console.WriteLine($" Номер строки : {ans[1]}");
}
Console.WriteLine("Введите кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  кол-во столбцов ");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,m];

FillArraay(matrix);
PrintArray(matrix);
MaximumRowAmount(matrix,m);
MinRowAmount(matrix,m);
