using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниране на променливи

			int a = 0, b = 0;
			int c = 0;
			string first = "Hello";
			string second = "World";
			object one = first + " " + second;
			string fourth = "0";


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

			//Въвеждане на входни параметри

			Console.Write("Моля въведете една дума:  ");
			fourth = (Console.ReadLine());

			Console.WriteLine("");

			Console.Write("Моля въведете едно число:  ");
			c = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("");
				
			//Печат на резултат

			Console.WriteLine("Резултата от конкатенацията на думата и числото e : " + (fourth + " " + c) + "\n\n");

			//Основни операции със стрингове

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";

			Console.WriteLine("Събиране с += :  " + test + "\n");

			test = test.Replace(", ", ";");
			Console.WriteLine("Работа с Replace :  " + test + "\n");

			Console.WriteLine("3ти знак: " + test.Split (';')[2] + "\n\n\n");

		}
	}
}
