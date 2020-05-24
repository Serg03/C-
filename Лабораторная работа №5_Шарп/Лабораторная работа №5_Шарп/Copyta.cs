using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__5_Шарп
{
	class Copyta : Mlekop, ICopyt
	{
		int Rog;
		public void inf5()
		{
			Console.WriteLine("Количество рогов:");           Rog = Convert.ToInt32(Console.ReadLine());
		}
		public int rog { get => Rog; set => Rog = value; }
	}
}
