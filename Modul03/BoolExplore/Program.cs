using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };
			int _ui = 0;

			Console.Write("Моля въведете индекс на число: ");
			string _input = Console.ReadLine ();

			bool _check01 = int.TryParse(_input, out _ui);
			bool _check02 = _ui <= _i.Length;
			bool _check03 = _ui > 0;

			if (_check01 && _check02 && _check03)
				{
					Console.WriteLine("\nЕлементът с индекс " + _ui + " e: " + _i[_ui - 1] + "\n\n");
				}

			if (!_check01)
				{
					Console.WriteLine("\nГрешка! Въведете цяло число!\n\n\n ");
				}

			if (!_check02 && _check01)
				{
					Console.WriteLine("\nГрешка! Индексът е прекалено голям!\n\n\n ");
				}

			if (!_check03 && _check01)
				{
					Console.WriteLine("\nГрешка! Индексът е прекалено малък!\n\n\n");
				}

		}
	}
}
