int even(int arg) // от большего к меньшему
{
int remainder = 0;
remainder = arg % 2;
int index = 0;
Console.Write("Число = " );
 Console.WriteLine ( arg );
        ;
     if (remainder != 0)                                   // Проверка на четность это нужно для того чтобы определить как счиать четные числа в интервале от 0 до N. так как если число четное мы от него постепено в цикле вычетаем -2, а если не четное мы вначале вычетаем единицу а после так же вычетаем по 2 доходя до 0
     {
        
        Console.WriteLine("Все четные числа содержащиеся в числе от Большего к меньшему ---> " ) ;
         int ans = arg;
        ans = ans -1;
        while (index < arg)                                 // цыкл для вывода каждого четного числа в N нечетном
        {
            if (ans == 0)                                   // чтоб не 0 не водил в наш деапазон я поставил брейк поинт
            {
                break;
            }
          Console.Write(ans);
          ans = ans - 2;
          Console.Write(" ") ;
          index = index + 2;
        }
     }

     else
     {
        Console.Write("Все четные числа содержащиеся в числе от Большего к меньшему ---> " );
        
        int ans = arg;
        
        while (index < arg )                                  // цыкл для вывода каждого четного числа в N четном
        {
            if (ans == 0)                                     // чтоб не 0 не водил в наш деапазон я поставил брейк поинт
            {
                break;
            }
        
          
          Console.Write(ans);
          ans = ans - 2;
          Console.Write(" ") ;
          index = index + 2;
        
        }
     }
      
     return arg;


} 
int even002(int arg) // от меньшего к большему
{
    int remainder = 0;
    remainder = arg % 2;
    int index = 2;
    Console.Write("Число = " );
    Console.WriteLine ( arg );
        
     if (remainder != 0)                                   // Проверка на четность это нужно для того чтобы определить как счиать четные числа в интервале от 0 до N. так как если число четное мы от него постепено в цикле вычетаем -2, а если не четное мы вначале вычетаем единицу а после так же вычетаем по 2 доходя до 0
     {
        
        Console.WriteLine("Все четные числа содержащиеся в числе от меньшего к большекму ---> " ) ;
        int ans = arg;
        ans = ans - 1;
        while (index <= arg)                                 // цыкл для вывода каждого четного числа в N нечетном
        {
            if (ans == 0)                                   // чтоб не 0 не водил в наш деапазон я поставил брейк поинт
            {
                break;
            }
            Console.Write(index);
            ans = ans - 2;
            Console.Write(" ") ;
            index = index + 2;
        }
     }

     else
     {
        Console.Write("Все четные числа содержащиеся в числе от меньшего к большекму ---> " );
        
        int ans = arg;
        
        while (index <= arg )                                  // цыкл для вывода каждого четного числа в N четном
        {
            if (ans == 0)                                     // чтоб не 0 не водил в наш деапазон я поставил брейк поинт
            {
                break;
            }
        
            
            Console.Write(index);
            ans = ans - 2;
            Console.Write(" ") ;
            index = index + 2;
            
        }
     }
      
     return arg;
}
void space()
{
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
}


int N = 10; //new Random().Next(1,100);

space();
even002(N);
space();
even(N); 