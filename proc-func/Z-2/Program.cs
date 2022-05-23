using System;

namespace Z_2
{
    class Program
    {
        static double f (double x)
        {
            double y;
            if (x < 0) y = -4;
            else if ((x >= 0) && (x<1)) y = Math.Pow(x,2);
            else y = 2;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i<= b; i+= h)
                Console.WriteLine("f({0:f2}) = {1:f4}", i,f(i));
        }
    }
}
