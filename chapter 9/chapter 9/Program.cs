using System;

namespace chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" cash : ");
            int csh_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("percentage : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" cash you want : ");
            int csh_c = Convert.ToInt32(Console.ReadLine());

            if (csh_c > csh_a)
            {
                if (b < 100 && b > 0)
                {
                    int mounth_prof = ((csh_a * b) / 100) / 12;
                    double full_prof = csh_c - csh_a;
                    double mounth = full_prof / mounth_prof;
                    Console.WriteLine("{0} year", mounth/12);
                }
                else
                {
                    Console.WriteLine("wrong!try again");
                }

            }
            else
            {
                Console.WriteLine("wrong!try again");
            }
            Console.ReadKey();
        }
    }
}
