using System;

namespace ConsoleApp5
{
    class test
    {
        private string id,kname,date_reg;
        private double money;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return kname; }
            set { kname = value; }
        }
        public string Date
        {
            get { return date_reg; }
            set { date_reg = value; }
        }
        public double Money
        {
            get { return money; }
            set { money = value; }
        }
        public test(string get_id,string get_name,string get_date,double get_Money)
        {
            id = get_id;
            kname = get_name;
            date_reg = get_date;
            money = get_Money;

        }
        public double bime()
        {
            return money * 7 / 100;
        }
        public double task()
        {
            if (money >= 6500000)
                return money * 10 / 100;
            else
                return 0;
        }
        public double end_money()
        {

            return money-(task()+bime());
        }
        public test() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("shomare karmandi : ");
            string id = Console.ReadLine();
            Console.Write("name : ");
            string name = Console.ReadLine();
            Console.Write("tarikh estekhdam : ");
            string date = Console.ReadLine();
            Console.Write("hoghoogh nakhales : ");
            double money = Convert.ToDouble(Console.ReadLine());
            test a1 = new test(id, name, date, money);
            Console.WriteLine("-------------------------");
            Console.Write("hoghooghe khales : ");
            Console.WriteLine(a1.end_money());
            Console.ReadKey();
            

        }
    }
}
