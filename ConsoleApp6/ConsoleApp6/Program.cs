using System;

namespace ConsoleApp6
{
    class test
    {
        private double r;//shoa
        private double x;//tul
        private double y;//arz
        private double h;//ertefa
        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
                else
                    Console.WriteLine("value wrong");
            }
        }
        public double X
        {
            get { return x; }
            set
            {
                if (value > 0)
                    x = value;
                else
                    Console.WriteLine("value wrong");
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (value > 0)
                    y = value;
                else
                    Console.WriteLine("value wrong");
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                    h = value;
                else
                    Console.WriteLine("value wrong");
            }
        }
        public double mo_dayere()
        {
            return r * 2 * Math.PI;
        }
        public double ma_dayere()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        public double mo_moraba()
        {
            return x * 4;
        }
        public double ma_moraba()
        {
            return x * x;
        }
        public double mo_mostatil()
        {
            return (x + y) * 2;
        }
        public double ma_mostatil()
        {
            return x * y;
        }
        public double mo_mosalas()
        {
            return (x * 2) + h;
        }
        public double ma_mosalas()
        {
            return (x * h) / 2;
        }
        public double mo_zoozanaghe()
        {
            return (x + y) * 2;
        }
        public double ma_zoozanaghe()
        {
            return x * y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nesbat be shekl mord nazar adad bezanid :\n dayere(1)\n moraba(2)\n mostatil(3)\n mosalas(4)\n motavazi azlaa(5)");
            Console.WriteLine("___________________________________");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("___________________________________");
            test calc = new test();
            switch(a)
            {
                case 1://dayere
                    double r = Convert.ToDouble(Console.ReadLine());
                    calc.R = r;
                    Console.WriteLine("dayere");
                    Console.WriteLine("mohit :"+calc.mo_dayere());
                    Console.WriteLine("masahat :"+calc.ma_dayere());
                    break;
                case 2://moraba
                    double x = Convert.ToDouble(Console.ReadLine());
                    calc.X = x;
                    Console.WriteLine("moraba");
                    Console.WriteLine("mohit :" + calc.mo_moraba());
                    Console.WriteLine("masahat :" + calc.ma_moraba());


                    break;
                case 3://mostatil
                    double p = Convert.ToDouble(Console.ReadLine());
                    double q = Convert.ToDouble(Console.ReadLine());
                    calc.X = p;
                    calc.Y = q;
                    Console.WriteLine("mostatil");
                    Console.WriteLine("mohit :" + calc.mo_mostatil());
                    Console.WriteLine("masahat :" + calc.ma_mostatil());
                    break;
                case 4://mosalas
                    double d = Convert.ToDouble(Console.ReadLine());
                    double f = Convert.ToDouble(Console.ReadLine());
                    calc.X = d;
                    calc.H = f;
                    Console.WriteLine("mosalas");
                    Console.WriteLine("mohit :" + calc.mo_mosalas());
                    Console.WriteLine("masahat :" + calc.ma_mosalas());
                    break;
                case 5://motavaziolazlaa
                    double w = Convert.ToDouble(Console.ReadLine());
                    double g = Convert.ToDouble(Console.ReadLine());
                    double v = Convert.ToDouble(Console.ReadLine());
                    calc.X = w;
                    calc.Y = g;
                    calc.H = v;
                    Console.WriteLine("motavaziolazlaa");
                    Console.WriteLine("mohit :" + calc.mo_zoozanaghe());
                    Console.WriteLine("masahat :" + calc.ma_zoozanaghe());
                    break;
                default:
                    Console.WriteLine("enter between 1 to 5 !!!!");
                    
                    break;
            }
            Console.WriteLine("___________________________________");
            Console.ReadKey();
        }
    }
}
