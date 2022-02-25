using System;

namespace Unit_5
{
    class Program
    {
		static void Echo(string saidworld, int deep)
		{
			var modif = saidworld;

			if (modif.Length > 2)
			{
				modif = modif.Remove(0, 2);
			}

			Console.BackgroundColor = (ConsoleColor)deep;
			Console.WriteLine("..." + modif);

			if (deep > 1)
			{
				Echo(modif, deep - 1);
			}
		}
		static decimal Factorial(int x)
        {
			if (x == 0)
			{
				return 1;
			}
			else
			{
				return x * Factorial(x - 1);
			}
		}
		private static int PowerUp(int N, byte pow)
        {
			if (pow == 0)
            {
				return 1;
			}
			else
            {
                if (pow == 1)
                {
					return N;
                }
				else
                {
					return N * PowerUp(N, --pow);
                }
            }
		}
		static void Main(string[] args)
		{
            #region
            //Console.WriteLine("Напишите что-то");
            //var str = Console.ReadLine();

            //Console.WriteLine("Укажите глубину эха");
            //var deep = int.Parse(Console.ReadLine());

            //Echo(str, deep);
            #endregion
            #region
            //Console.WriteLine("Введите число для вычисления факториала: ");
            //var x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Результат вычисления факториала: ");
            //Console.WriteLine(Factorial(x));
            #endregion
            Console.WriteLine("Введите исходное число: ");
			int N = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите степень: ");
			byte pow = Convert.ToByte(Console.ReadLine());

			Console.WriteLine(PowerUp(N, pow));

			Console.ReadLine();
		}
	}
}
