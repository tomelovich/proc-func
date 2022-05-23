using System;

namespace Z_1
{
    
    class Program
    {
         static int secondNumber(int x)
         {
            x = Math.Abs(x);
            return x / 10 % 10;
         }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a ( a>9 ):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b ( b>9 ):");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c ( c>9 ):");
            int c = Convert.ToInt32(Console.ReadLine());
            int z = secondNumber(a) + secondNumber(b) - secondNumber(c);
            Console.WriteLine("f(a) + f(b) - f(c) = {0}",z);
        }
    }
}
