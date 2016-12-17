using System;

namespace ClassExplorer
{
	public class person
	{
		private string simpleString = "";
		private string user = "";
		private string hiddenString = "";

		public person( string _ini )
		{
			getUser(_ini);
			setWelcomeText();
		}
		private void getUser(string _ini)
		{
			if (_ini == "pass1") hiddenString = "Потребител1";
			if (_ini == "pass2") hiddenString = "Потребител2";

			user = hiddenString;
		}
		private void setWelcomeText()
		{
			if (hiddenString.Length > 0)
				simpleString = "\nДобре дошли отново, " + user + "!\n\n";
			else
				simpleString = "\nВие нямате достъп до тази програма!\n\n";
		}
		public string getWelcomeMessage()
		{
			return simpleString;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Парола: "); string _user = Console.ReadLine();
			//Дефиниране на клас
			person _person = new person(_user);

			//Достъпване на клас
			Console.WriteLine(_person.getWelcomeMessage());
		}
	}
}
