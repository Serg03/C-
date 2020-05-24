using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__5_Шарп
{
	class Animal : IAnimal
	{
		int Age;
		string Name;
		string Vid;
		public int age { get => Age; set => Age = value; }
		public string name { get => Name; set => Name = value; }
		public string vid { get => Vid; set => Vid = value; }

		
	}
}
