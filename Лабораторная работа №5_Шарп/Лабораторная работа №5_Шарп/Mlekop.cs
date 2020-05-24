using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__5_Шарп
{
	class Mlekop : Animal, IMleko
	{
		public string Name;
		public int Age;
		public string Vid;
		public double Ves;
		
			public void inf1() 
		{
			Console.WriteLine("Имя:");  			Name = Console.ReadLine();
		}
		public void inf2()
		{
			Console.WriteLine("Возраст:");              Age = Convert.ToInt32(Console.ReadLine());
		}
		public void inf3()
		{
			Console.WriteLine("Вид:");            Vid = Console.ReadLine();
		}
		public void inf4()
		{
			Console.WriteLine("Вес:");              Ves = Convert.ToDouble(Console.ReadLine());
		}
		
		public double ves { get => Ves; set => Ves = value; }
	}
}
