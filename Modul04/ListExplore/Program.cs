using System;
using System.Collections.Generic;
namespace ListExplore
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Дефиниции
			string _userinput = "";
			List<int> _list = new List<int>();

			//List
			_list.Add(5);
			_list.Add(3);
			_list.Add(9);

			//Потребителски вход

			do
			{
				Console.Write("? ");
				_userinput = Console.ReadLine();

				//Добавяне на стойности
				//add <int>

				try
				{
					if (_userinput.ToLower().Contains("add"))
					{
						int _add = 0;

						if (int.TryParse(_userinput.Split(' ')[1], out _add))
						{
							_list.Add(_add);
						}

						Console.WriteLine("\n");

						}
				} catch {}
			

				//Преглед на List
				if (_userinput.ToLower().Contains("show"))
				{
					Console.Write("\n_list: ");

					for (int i = 0; i < _list.Count; i++)
					{
						Console.Write(_list[i]);
						if (i != _list.Count - 1) Console.Write(", ");
					}
					Console.WriteLine("\n");
				}

				//Размер на List

				if (_userinput.ToLower().Contains("size"))
				{
					Console.WriteLine("\nРазмер на списъка: " + _list.Count + " елемента\n");
				}




			} while (_userinput != "exit");

			Console.WriteLine();


		}
	}
}
