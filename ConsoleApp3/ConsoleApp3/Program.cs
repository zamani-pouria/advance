using System;

namespace ConsoleApp3
{
    class test
    {
        private double u1, d1, u2, d2;

        public double U1
        {
            get { return u1; }
            set { u1 = value; }
        }
        public double D1
        {
            get { return d1; }
            set { d1 = value; }
        }
        public double U2
        {
            get { return u2; }
            set { u2 = value; }
        }
        public double D2
        {
            get { return d2; }
            set { d2 = value; }
        }
        public test(double U1, double D1, double U2, double D2)
        {
            u1 = U1;
            d1 = D1;
            u2 = U2;
            d2 = D2;
        }

        public bool check_num()
        {
            if(d1>0&&d2>0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("WRONG NUMBERSSSSS!!!");
                return false;
            }
        }

        public double sum()
        {
            double result = (u1 / d1) + (u2 / d2);
            return result;
        }
        public double mines()
        {
            double result = (u1 / d1) - (u2 / d2);
            return result;
        }
        public double zarb()
        {
            double result = (u1 / d1) * (u2 / d2);
            return result;
        }
        public double taghsim()
        {
            double result = (u1 / d1) / (u2 / d2);
            return result;
        }
        public test() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double u1, u2, d1, d2;
            Console.WriteLine("kasr aval :");
            u1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kasr dovom :");
            u2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--");
            d2 = Convert.ToDouble(Console.ReadLine());
            test a1 = new test(u1, d1, u2, d2);
            if (a1.check_num())
            {
                Console.Write("hasel jam : ");
                Console.WriteLine(a1.sum());
                Console.Write("hasel tafrigh : ");
                Console.WriteLine(a1.mines());
                Console.Write("hasel zarb : ");
                Console.WriteLine(a1.zarb());
                Console.Write("hasel taghsim : ");
                Console.WriteLine(a1.taghsim());
            }
            

            Console.ReadKey();
        }
    }
}
