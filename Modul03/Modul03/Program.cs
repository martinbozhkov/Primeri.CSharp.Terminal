using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double a = 0, b = 0, c = 0;

			Console.Write("Моля въведете a =  "); a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Моля въведете b =  "); b = Convert.ToDouble(Console.ReadLine());

			//Форматиране с дименсия
			string _format = "#0.00";
			Console.WriteLine("\nРазликата a / b =  " + (a / b).ToString("C2") + "\n\n");

			//Степенуване
			c = Math.Pow (a, b);
			Console.WriteLine("a ^ b =  " + c.ToString(_format) + "\n");

			//Коренуване
			c = Math.Sqrt ( b );
			Console.WriteLine("b ^ 1/2 =  " + c.ToString(_format) + "\n");

			//Закръгления
			c = Math.Round (a / b) ;
			Console.WriteLine("Разликата a / b =  " + c.ToString() + "\n\n");


		}
	}
}
