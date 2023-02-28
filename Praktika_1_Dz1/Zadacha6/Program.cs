int even(int arg)
{
int remainder = 0;
remainder = arg % 2;
     if (remainder != 0) 
     {
        Console.Write("Число нечетное ! ") ;
     }
     else
     {
        Console.Write("Число четное ! ");
     }
      Console.Write ("Число = " );
        Console.WriteLine ( arg ) ;
     return arg;


} 

int a = new Random().Next(1,1000);

even(a);

