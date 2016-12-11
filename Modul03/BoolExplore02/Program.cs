using System;

namespace BoolExplore02
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };
			int _ui = 0;

			Console.Write("Моля въведете индекс на число: ");
			string _input = Console.ReadLine();

			bool _check01 = int.TryParse(_input, out _ui);

			//Улавяне на грешки с try и catch

			try
			{
				Console.Write("\n\nЕлемент " + _ui.ToString() + " от масива е: ");
				Console.WriteLine(_i[_ui - 1]);
			}
			catch
			{
				Console.WriteLine("<недефиниран елемент>\n\n");
			}


			//Използване на условно присвояване

			//_ui = (_ui <= _i.Length) ? _ui: 3;
			//_ui = (_ui > 0) ? _ui : 1;


			//Използване на оператор Switch

			//switch (_ui)
			//{   
			//	case 1:
			//		{
			//			Console.Write("\n\n1ви елемент от масива е: ");
			//			Console.WriteLine(_i[_ui - 1] + "\n\n");
			//			break;
			//		}
			//	case 2:
			//		{
			//			Console.Write("\n\n2ри елемент от масива е: ");
			//			Console.WriteLine(_i[_ui - 1] + "\n\n");
			//			break;
			//		}
			//	case 3:
			//		{
			//			Console.Write("\n\n3ти елемент от масива е: ");
			//			Console.WriteLine(_i[_ui - 1] + "\n\n");
			//			break;
			//		}
			//	default:
			//		{
			//			Console.Write("\n\nВ масива няма стойност за този индекс. \nОпитайте с индекс между 1 и 3! \n\n\n");
			//			break;
			//		}
			//}
			}
	}
}
