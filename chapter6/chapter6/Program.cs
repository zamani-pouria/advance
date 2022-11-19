using System;

namespace chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("welcome please enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int p2 = pow2(a);
            int p3 = pow3(a);
            Console.WriteLine("power2 of your number is {0} and power3 of your number is {1}",p2,p3);
            Console.ReadKey();
        }
        private static int pow2(int a)
        {
            return a * a;
        }
        private static int pow3(int a)
        {
            return a * a * a;
        }
    }
}
