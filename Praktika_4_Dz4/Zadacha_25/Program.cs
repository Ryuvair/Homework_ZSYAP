void DegreeOfNumber(double arg1, double arg2)                // Первыый аргумент должен присваивать значения числа которое хотим возвести в степень
{                                                    // Второе аргумент должен присваивать значение степени
    double ans = Math. Pow(arg1, arg2);

    Console.WriteLine("Число : ") ;
    Console.Write(arg1);
    Console.Write(" В степени : ") ;
    Console.Write(arg2);
    Console.Write(" = ") ;
    Console.Write(ans);
}

Console.WriteLine("Введите число которое хотите возвести в степень");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите степень числа");
double B = double.Parse(Console.ReadLine());

DegreeOfNumber(A,B);