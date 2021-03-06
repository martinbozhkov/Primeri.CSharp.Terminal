﻿using System;

namespace ClassExplorer
{
	public class person
	{
		private string _userName = "";
		private string _userPass = "";

		private string _userID = "";
		private string _userFName = "";
		private string _userLName = "";

		public string userName
		{
			get { return _userName; }
		}

		public string userPass
		{
			get { return _userPass; }
		}

		public string userID
		{
			get { return _userID; }
			set { _userID = value; }
		} 

		public string userFName
		{
			get { return _userFName; }
			set { _userFName = value; }
		}

		public string userLName
		{
			get { return _userLName; }
			set { _userLName = value; }
		}

		public person( string _user, string _pass )
		{
			checkUser (_user, _pass);
		}

		private bool checkUser (string _user, string _pass)
		{
			if (_user == "user" && _pass == "pass")
				_userName = _user; _userPass = _pass;
			{
				//Попълване на пропъртита
				userID = "ID: 4455845";
				userFName = "Martin";
				userLName = "Bozhkov";

				return true;
			}
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Потребител: "); string _user = Console.ReadLine();
			Console.Write("Парола: "); string _pass = Console.ReadLine();

			//Дефиниране на клас
			person _person = new person(_user, _pass);

			//Достъпване на клас
			Console.WriteLine("\nИме: " + _person.userFName + " " + _person.userLName);
			Console.WriteLine("Потребителско " + _person.userID + "\n\n");
		}
	}
}
