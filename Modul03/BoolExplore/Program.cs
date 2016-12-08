using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниране на bool

			//bool _test = 5 > 10;
			//Console.WriteLine(_test);


			//Функции на bool
			int[] _i = new int[] { 4, 3, 2 };

			Console.Write("Моля въведете индекс на число: ");
			int _ui = Convert.ToInt32(Console.ReadLine());

			//bool _check01 = _ui <= _i.Length;
			//bool _check02 = _ui > 0;

			////Console.WriteLine(_check01);
			////Console.WriteLine(_check02);
			////Console.WriteLine(_i [_ui - 1]);

			////Логически функции на bool

			//bool _exp01 = _check01 && _check02;		// Логическо И "&&"
			//bool _exp02 = _check01 || _check02;		// Логическо ИЛИ "||"
			//bool _exp03 = ! _check01;				// Отрицание "!"


			//Console.WriteLine("\nЛогическо И: " + _exp01.ToString ());
			//Console.WriteLine("\nЛогическо ИЛИ: " + _exp02.ToString());			
			//Console.WriteLine("\nОтрицание на " + _check01.ToString() + ": " + _exp03 + "\n\n");

			if (_ui > 0 && _ui <= _i.Length)
			{
				Console.WriteLine("\nЕлементът с индекс " + _ui + " e: " + _i[_ui - 1] + "\n\n");
			}
			else {
				if (_ui >= _i.Length)
				{
					Console.WriteLine("\nИндекса е прекалено голям!\n\n\n ");
				}
				if (_ui <= 0)
				{
					Console.WriteLine("\nИндекса е прекалено малък!\n\n\n ");
				}
			}


			}
	}
}
