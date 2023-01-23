using System;

namespace ConsoleApp4
{
    class test
    {
        private double x1, y1, x2, y2;

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public test(double X1, double Y1, double X2, double Y2)
        {
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }

        public double calc()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        public test() { }
    }
        class Program
    {

        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            Console.WriteLine("x of first point:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y of first point:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x of second point:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y of second point:");
            y2 = Convert.ToDouble(Console.ReadLine());
            test a1 = new test(x1, y1, x2, y2);
            
            Console.WriteLine("answer :");
            Console.WriteLine(a1.calc());
            Console.ReadKey();
        }
    }
}
