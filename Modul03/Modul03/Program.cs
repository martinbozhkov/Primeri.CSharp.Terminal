using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double a = 0, b = 0;

			Console.Write("Моля въведете a =  "); a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Моля въведете b =  "); b = Convert.ToDouble(Console.ReadLine());

			string _format = "C2";

			Console.WriteLine("\n\nРазликата a / b =  " + (a / b).ToString (_format) + "\n\n");
		}
	}
}
