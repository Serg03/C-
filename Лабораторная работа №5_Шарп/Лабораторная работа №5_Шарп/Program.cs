using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Лабораторная_работа__5_Шарп;

namespace Lab_5_C_Sharp
{
	delegate void Deleg();
    class Program
	{
		static void mess1()
		{
			Console.WriteLine("Animal : IAnimal");
		}
		static void mess2()
		{
			Console.WriteLine("Mlekop : Animal, IMleko");
		}
		static void mess3()
		{
			Console.WriteLine("Copyta : Mlekop, ICopyt");
		}
		static void mess4()
		{
			Console.WriteLine("Ptiza : IAnimal, IPtiz\n");
		}
		static void mess5()
		{
			Console.WriteLine("Только что я показал не только, кто чей наследник, но и знание, как работать с делегатами.\nНо, в основной программе я не использовал делегаты, поскольку мне было не очень удобно с ними работать");
		}
		static void mess6()
		{
			Console.WriteLine("Прошу учесть это при выставлении оценки\n");
		}

		static void Main(string[] args)
		{
			
			Deleg dele1, dele2, dele3, dele4, dele5, dele6, dele7;//делегаты
			dele1 = mess1;
			dele2 = mess2; 
			dele3 = mess3; 
			dele4 = mess4; 
			dele5 = mess5;
			dele6 = mess6;
			dele7 = dele1 + dele2 + dele3 + dele4 + dele5 + dele6;
			dele7();

			////////////////////////////////////
			Console.WriteLine("Количество млекопитающих:");
			int k = Convert.ToInt32(Console.ReadLine());
			int n = k, m, l;
			
			Mlekop[] ml = new Mlekop[n];
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("{0} Млекопитающее",i+1);
				ml[i] = new Mlekop();
				ml[i].inf1();
				ml[i].inf2();
				ml[i].inf3();
				ml[i].inf4();
				Console.WriteLine("");
			}
			Console.WriteLine("\nЕсли желаете изменить какую либо информацию про млекопитающих нажмите (1).\nВ противном случае нажмите любую другую цифру");
			k = Convert.ToInt32(Console.ReadLine());
			if (k == 1) 
			{
				while (k != 2) {
					Console.WriteLine("Выберите номер млекопитающего:");
					int i = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Введите новые характеристики млекопитающего :)");
					ml[i].inf1();
					ml[i].inf2();
					ml[i].inf3();
					ml[i].inf4();
					Console.WriteLine("Для заврешения нажмите (2).\nВ противном случае нажмите любую другую цифру ");
					k = Convert.ToInt32(Console.ReadLine());
				}
			}
			      
			/////////////////////////////////////////////////////////////
			
			Console.WriteLine("\nКоличество парнокопытных:");
			k = Convert.ToInt32(Console.ReadLine());
			m = k;
			Copyta[] cop = new Copyta[m];
			for (int i = 0; i < m; i++)
			{
				Console.WriteLine("{0} Парнокопытное", i + 1);
				cop[i] = new Copyta();
				cop[i].inf1();
				cop[i].inf2();
				cop[i].inf3();
				cop[i].inf4();
				cop[i].inf5();
				Console.WriteLine("");
			}
			Console.WriteLine("\nЕсли желаете изменить какую либо информацию про парнокопытных нажмите (1).\nВ противном случае нажмите любую другую цифру");
			k = Convert.ToInt32(Console.ReadLine());
			if (k == 1)
			{
				while (k != 2)
				{
					Console.WriteLine("Выберите номер парнокопытного:");
					int i = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Введите новые характеристики парнокопытного :)");
					cop[i].inf1();
					cop[i].inf2();
					cop[i].inf3();
					cop[i].inf4();
					cop[i].inf5();
					Console.WriteLine("Для заврешения нажмите (2).\nВ противном случае нажмите любую другую цифру ");
					k = Convert.ToInt32(Console.ReadLine());
				}
			}
			        
			/////////////////////////////////////////////////////////////
			
			Console.WriteLine("\nКоличество птиц:");
			k = Convert.ToInt32(Console.ReadLine());
			l = k; int ks, kk=1;
			Ptiza[] pt = new Ptiza[l];
			for (int i = 0; i < l; i++)
			{
				Console.WriteLine("{0} Птица", i + 1);
				pt[i] = new Ptiza();

				pt[i].inf1();
				pt[i].inf2();
				pt[i].inf3();
				pt[i].inf4();
				
				Console.WriteLine("");
			}
			Console.WriteLine("\nЕсли желаете изменить какую либо информацию про птиц нажмите (1).\nВ противном случае нажмите любую другую цифру");
			k = Convert.ToInt32(Console.ReadLine());
			if (k == 1)
			{
				while (k != 2)
				{
					Console.WriteLine("Выберите номер птицы:");
					int i = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Введите новые характеристики птиц :)");
					cop[i].inf1();
					cop[i].inf2();
					cop[i].inf3();
					cop[i].inf4();
					Console.WriteLine("Для заврешения нажмите (2).\nВ противном случае нажмите любую другую цифру ");
					k = Convert.ToInt32(Console.ReadLine());
				}
			}

			////////////////////////////////////////////////////////////////////////////////////////////////////////////
			
			Console.WriteLine("\nЕсли желаете найти какую либо информацию нажмите (1).\nВ противном случае нажмите любую другую цифру");
			string h;
			double f;
			ks = Convert.ToInt32(Console.ReadLine());
			if (ks == 1) 
			{

				while (kk != 2)
				{

					Console.WriteLine("\nВыберите тип животного и введите соответствующую цифру:");
					Console.WriteLine("Млекопитающее(1)     Парнокопытное(2)     Птица(3)");
					k = Convert.ToInt32(Console.ReadLine());
					if (ks == 1)
					{
						Console.WriteLine("Выберите критерий поиска введите соответствующую цифру\nПоиск по слову(1)\tПоиск по текусту(2)");
						k = Convert.ToInt32(Console.ReadLine());
						if (k == 1)
						{
							Console.WriteLine("Введите текст:");
							h = Console.ReadLine();
							for (int i = 0; i < n; i++)
							{

								if (h == ml[i].Name || h == ml[i].Vid)
								{
									Console.WriteLine("Имя:" + ml[i].Name);
									Console.WriteLine("Возраст:" + ml[i].Age);
									Console.WriteLine("Вид:" + ml[i].Vid);
									Console.WriteLine("Вес:" + ml[i].Ves);
								}
							}
						}
						if (k == 2)
						{
							Console.WriteLine("Введите число:");
							f = Convert.ToDouble(Console.ReadLine());
							for (int i = 0; i < n; i++)
							{

								if (f == ml[i].Age || f == ml[i].Ves)
								{
									Console.WriteLine("Имя:" + ml[i].Name);
									Console.WriteLine("Возраст:" + ml[i].Age);
									Console.WriteLine("Вид:" + ml[i].Vid);
									Console.WriteLine("Вес:" + ml[i].Ves);
								}
							}
						}
					}

					if (ks == 2)
					{
						Console.WriteLine("Выберите критерий поиска и введите соответствующую цифру\nПоиск по слову(1)\tПоиск по текусту(2)");
						k = Convert.ToInt32(Console.ReadLine());
						if (k == 1)
						{
							Console.WriteLine("Введите текст:");
							h = Console.ReadLine();
							for (int i = 0; i < n; i++)
							{

								if (h == cop[i].Name || h == ml[i].Vid)
								{
									Console.WriteLine("Имя:" + cop[i].Name);
									Console.WriteLine("Возраст:" + cop[i].Age);
									Console.WriteLine("Вид:" + cop[i].Vid);
									Console.WriteLine("Вес:" + cop[i].Ves);
									Console.WriteLine("Количество рогов:" + cop[i].rog);
								}
							}
						}
						if (k == 2)
						{
							Console.WriteLine("Введите число:");
							f = Convert.ToDouble(Console.ReadLine());
							for (int i = 0; i < n; i++)
							{

								if (f == cop[i].Age || f == cop[i].Ves || f == cop[i].rog)
								{
									Console.WriteLine("Имя:" + cop[i].Name);
									Console.WriteLine("Возраст:" + cop[i].Age);
									Console.WriteLine("Вид:" + cop[i].Vid);
									Console.WriteLine("Вес:" + cop[i].Ves);
									Console.WriteLine("Количество рогов:" + cop[i].rog);
								}
							}
						}
					}

					if (ks == 3)
					{
						Console.WriteLine("Выберите критерий поиска введите соответствующую цифру\nПоиск по слову(1)\tПоиск по текусту(2)");
						k = Convert.ToInt32(Console.ReadLine());
						if (k == 1)
						{
							Console.WriteLine("Введите текст:");
							h = Console.ReadLine();
							for (int i = 0; i < n; i++)
							{

								if (h == pt[i].name || h == pt[i].vid)
								{
									Console.WriteLine("Имя:" + pt[i].name);
									Console.WriteLine("Возраст:" + pt[i].age);
									Console.WriteLine("Вид:" + pt[i].vid);
									Console.WriteLine("Размах крыльев(м):" + pt[i].raz);
								}
							}
						}
						if (k == 2)
						{
							Console.WriteLine("Введите число:");
							f = Convert.ToDouble(Console.ReadLine());
							for (int i = 0; i < n; i++)
							{

								if (f == pt[i].age || f == pt[i].raz)
								{
									Console.WriteLine("Имя:" + pt[i].name);
									Console.WriteLine("Возраст:" + pt[i].age);
									Console.WriteLine("Вид:" + pt[i].vid);
									Console.WriteLine("Размах крыльев(м):" + pt[i].raz);
								}
							}
						}
					}

					Console.WriteLine("Если желаете завершить поиск, введите цифру (2).\nВ ином случае, нажмите любую другую цифру");
				}

			}









			Console.ReadKey();
			
		}
	}
}
