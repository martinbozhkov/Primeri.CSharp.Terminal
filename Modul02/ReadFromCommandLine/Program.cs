using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниране на променливи

			int a = 0, b = 0;

			Console.WriteLine("След като въведете число, натиснете Enter." + "\n\n");

			//Въвеждане на входни параметри

			Console.Write("Моля въведете a:  ");
			a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("");

			Console.Write("Моля въведете b:  ");
			b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("");

			//Печат на резултат

			Console.WriteLine("Резултата a + b e: " + (a + b).ToString () + "\n\n\n");


		}
	}
}
