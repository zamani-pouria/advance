using System;

namespace chapter8
{
    class Program
    {
		public static void Main(string[] args)
		{
			Console.WriteLine("enter numbers :");
			Console.Write("first num : ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("second num : ");
			int b = Convert.ToInt32(Console.ReadLine());
			int Bmm = BMM(a, b);
			int Kmm = KMM(a, b);
			Console.WriteLine("bmm : {0}", Bmm);
			Console.WriteLine("kmm : {0}", Kmm);
			Console.ReadKey();
		}

		public static int BMM(int a, int b)
		{
			int bmm = 0;

			if (a == 0 || b == 0)
			{
				bmm = 0;
			}
			else
			{
				if (a > b)
				{
					for (int i = b; i > 0; i--)
					{
						if (a % i == 0 && b % i == 0)
						{
							bmm = i;
							break;
						}

					}
				}
				else if (a < b)
				{
					for (int i = a; i > 0; i--)
					{
						if (a % i == 0 && b % i == 0)
						{
							bmm = i;
							break;
						}

					}
				}
				else
				{
					bmm = a;
				}


			}
			return bmm;

		}

		public static int KMM(int a, int b)
		{
			int kmm = 0;

			if (a == 0 || b == 0)
			{
				kmm = 0;
			}
			else
			{
				if (a == b)
				{
					kmm = a;
				}
				else if (a < b)
				{
					if (b % a == 0)
					{
						kmm = b;
					}
					else
					{
						int factor = 2;

						bool foundlcm = false;
						while (!foundlcm)
						{
							int multiple = factor * b;
							if (multiple % a == 0)
							{
								kmm = multiple;
								foundlcm = true;

							}
							factor++;
						}
					}

				}
				else if (a > b)
				{
					if (a % b == 0)
					{
						kmm = a;
					}
					else
					{
						int factor = 2;

						bool foundlcm = false;
						while (!foundlcm)
						{
							int multiple = factor * a;
							if (multiple % b == 0)
							{
								kmm = multiple;
								foundlcm = true;
							}
							factor++;
						}
					}
				}

			}
			return kmm;
		}
    }
}
