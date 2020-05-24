using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__5_Шарп
{
	class Ptiza : IAnimal, IPtiz
	{
		int Age;
		string Name;
		string Vid;
		double R;
		public void inf1()
		{
			Console.WriteLine("Имя:");			Name = Console.ReadLine();
		}
		public void inf2()
		{
			Console.WriteLine("Возраст:");			Age = Convert.ToInt32(Console.ReadLine());
		}
		public void inf3()
		{
			Console.WriteLine("Вид:");          Vid = Console.ReadLine();
		}
		public void inf4()
		{
			Console.WriteLine("Размах крыльев(м):");         R = Convert.ToDouble(Console.ReadLine());
		}
		public double raz { get => R; set => R = value; }

		public int age { get => Age; set => Age = value; }
		public string name { get => Name; set => Name = value; }
		public string vid { get => Vid; set => Vid = value; }
	}
}
