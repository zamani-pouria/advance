using System;

namespace chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
                mohit(a, b, c);
            else
                Console.WriteLine("wrong numbers!");
            Console.ReadKey();

        }
        private static void mohit(int a,int b,int c)
        {
            int final = a + b + c;
            Console.WriteLine(final);
        }
    }
}
