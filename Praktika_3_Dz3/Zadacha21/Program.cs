//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Coordinate3DSearch(double arg1_1, double arg1_2, double arg1_3, double arg2_1, double arg2_2, double arg2_3)
{
double ans = Math.Sqrt( Math.Pow((arg2_1 - arg1_1), 2) + Math.Pow((arg2_2 - arg1_2), 2)+ Math.Pow((arg2_3 - arg1_3), 2));
Console.WriteLine("                                 ");
Console.WriteLine("                                 ");
Console.Write("расстояние между точками в 3D пространстве : ");
Console.WriteLine(ans);
return 0;
}

Console.WriteLine("Введите координату А1 ");
double A1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату А2 ");
double A2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату А3 ");
double A3 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B1 ");
double B1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B2 ");
double B2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B3 ");
double B3 = double.Parse(Console.ReadLine());

Coordinate3DSearch(A1, A2, A3, B1, B2, B3);