// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekendSearch(int arg)
{
    int i = 0;
    while (i < 1)
    {   
        if (arg <= 7 & arg > 0)
        {
            if (arg <= 5)
            {
                Console.WriteLine("Блин, проклятые будни");
                i++;
            }
            else
            {
                Console.WriteLine("Ура выходные!!!!!");
                i++;
            }
        }
        else
        {
            Console.WriteLine("Введено не коректное значение в недели всего 7 дней, пожалуйста помните об этом! ");
            Console.WriteLine("Ввыдите номер дня недeли");   
            int N = int.Parse(Console.ReadLine());
            arg = N;
        }
    }
}
Console.WriteLine("Веддите номер дня недели");

int DayOfTheWeek = int.Parse(Console.ReadLine());

WeekendSearch(DayOfTheWeek);

