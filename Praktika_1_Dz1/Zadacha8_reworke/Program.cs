int even(int arg)
{
    Console.WriteLine(arg);


 int count = arg % 2;
 arg = arg - count;
 int index = 2;
 int ans = arg;

  while (index <= arg)
  {
    Console.Write(index);
    Console.Write(" ");
    ans = ans - 2;
    index = index +2;

  }
  return 0;
}

int N = new Random().Next(1,100);

even(N);