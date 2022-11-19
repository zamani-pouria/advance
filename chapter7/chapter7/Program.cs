using System;

namespace chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please \r\n enter your age by day:");
            double a = Convert.ToDouble(Console.ReadLine());
            int yr = 0;
            int mo = 0;
            int wk = 0;
            int day = 0;
            yr = (int)a / 365;
            mo = (int)(a % 365) / 30;
            wk = (int)((a % 365) % 30) / 7;
            day = (int)((a % 365) % 30) % 7;
            Console.WriteLine("year : {0} \r\n mounth : {1} \r\n week : {2} \r\n day : {3}",yr,mo,wk,day);

            Console.ReadKey();
        }
    }
}
