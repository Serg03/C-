#include <cstdio>
#include <cstdlib>
#include <ctime>
#include <conio.h>
#include <string>
#include <iostream>
#include <fstream> 

using namespace std;

struct  Avto
		{
	        string Marka;
			string Proizv;
			string Tip;
			int MGod;
			double Stoim;
		};

struct  Gost
{
	string nazva;
	double stoim[3];
	string svobmest;
	int zayavki;
	int kolvodney;
};

/* Мне пришлось использовать if() для выбора программы, 
 поскольку на моём компьютере не получается вызывать подфункции.
    Я не знаю в чём причина, но постараюсь разобраться до следующей лабораторной. */


int main() 
{
	
	cout << "To start the first code, click 1:   ";
	int u; cin >> u;
    if (u == 1) 
	{
	cout << "14 Option:\nCreate a binary file with information about cars: \ n -car brand; \ n -manufacturer; \ n -type; \ n -year of release; \ n -price. \ N Show information about all cars, production time which are at least 5 years old and not manufactured in China.\n( Country names should be written in abbreviation or with a capital letter )\n( Entering data is required in English )\n";
	
	const int N = 4;
	Avto* avto = new Avto[N];
	int data = 2020;
	cout << "\n Tekuschiy God:  " << data << "\n\n";
	const char* path = "1.bin";

	for (int i = 0;i < N;i++)
	{
		cout << "car brand:  ";
		cin >> avto[i].Marka;
		cout << "manufacturer (country):  ";
		cin >> avto[i].Proizv;
		cout << "type:  ";
		cin >> avto[i].Tip;
		cout << "year of release:  ";
		cin >> avto[i].MGod;
		cout << "price:  ";
		cin >> avto[i].Stoim;
		cout << endl;
	}

	FILE* f_out, * f_in;
	f_out = fopen(path, "wb");
	fwrite(avto, sizeof(Avto), N, f_out);
	fclose(f_out);
	delete[] avto;
	avto = nullptr;

	Avto* restoredDB = new Avto[N];
	f_in = fopen(path, "rb");
	fread(restoredDB, sizeof(Avto), N, f_in);
	fclose(f_in);
	string Kyt = "China";
	for (size_t i = 0; i < N; i++)
	{
		if ((data- restoredDB[i].MGod >= 5) && (restoredDB[i].Proizv != Kyt))
		{
			cout << endl;
		    cout << "car brand:  " << restoredDB[i].Marka << "\nmanufacturer:  " << restoredDB[i].Proizv << "\ntype:  " << restoredDB[i].Tip;
		    cout << "\nyear of release:  " << restoredDB[i].MGod << "\price:  " << restoredDB[i].Stoim << endl;
		}
	}

    }
	/////////////////////////////////2///////////////////////////////////
 	cout << "\n\nTo start the second code, click 2:   ";
	cin >> u;
	if (u == 2)
	{
		system("CLS");

		cout << "14 Option:\nCreate a two-dimensional array of a real type with a dimension of 5 × 5.\nRewrite the binary file so that the values of the elements in each column are increased 2.5 times.\nPrint this array before and after changing the data in the file.";

		double mass[5][5];
		srand(time(NULL));
		cout << fixed;
		cout.precision(2);
		for (int i = 0;i < 5;i++)//создание массива
		{
			for (int j = 0;j < 5;j++)
			{
				mass[i][j] = (double)(rand()) / RAND_MAX * (10 - 0) + 0;
			}
		}

		cout << "\nEntered array:\n";
		for (int i = 0;i < 5;i++)//вывод массива
		{
			for (int j = 0;j < 5;j++)
			{
				cout << mass[i][j] << " ";

			}cout << endl;
		}cout << endl;
		const char* path2 = "2.bin";
		FILE* f_out, * f_in;
		f_out = fopen(path2, "wb");

		fwrite(mass, sizeof(mass), 1, f_out);//заполнение бинарного файла
		fclose(f_out);

		cout << "Read first array:\n";//считывание массива из файла
		double mass1[5][5];
		f_in = fopen(path2, "rb");
		fread(mass1, sizeof(mass1), 1, f_in);
		fclose(f_in);
		for (int i = 0;i < 5;i++)//показ массива и его изменение
		{
			for (int j = 0;j < 5;j++)
			{
				cout << mass1[i][j] << " ";
				mass[i][j] = mass[i][j] * 2.5;
			}cout << endl;
		}cout << endl;

		f_out = fopen(path2, "wb");
		fwrite(mass, sizeof(mass), 1, f_out);//заполнение бинарного файла изменённым массивом
		fclose(f_out);

		cout << "Read second array:\n";//считывание массива из файла
		double mass2[5][5];
		f_in = fopen(path2, "rb");
		fread(mass2, sizeof(mass2), 1, f_in);
		fclose(f_in);
		for (int i = 0;i < 5;i++)//показ массива
		{
			for (int j = 0;j < 5;j++)
			{
				cout << mass2[i][j] << " ";
			}cout << endl;
		}

	}
    /////////////////////////////////3///////////////////////////////////
     cout << "\n\nTo start the third code, click 2:   ";
     cin >> u;
	 if (u == 2)
	 {
		 system("CLS");
		 cout << "Create a binary file whose components are a structure containing the following fields:\n - the name of the hotel\n -cost of hotel rooms(array for 3 rooms: one - room, two - room, etc.) (price)\n -Availability of free places for each room(yes / no);\n -number of applications for accommodation in rooms;\n -number of days pre - paid per room.\nRewrite the binary so that the room rate is reduced by 5 % if the number of days on advance payment is 10 days, and by 10 % if more than 20 days";

		 const int n = 3;
		 Gost* gost = new Gost[n];
		 const char* path3 = "3.bin";
		 for (int i = 0;i < n;i++)
		 {
			 cout << "  The name of the hotel:\n";
			 cin >> gost[i].nazva;
			 cout << "  The cost of hotel rooms (one-room):\n";
			 cin >> gost[i].stoim[0];
			 cout << "  The cost of hotel rooms (two-room):\n";
			 cin >> gost[i].stoim[1];
			 cout << "  The cost of hotel rooms (three-room):\n";
			 cin >> gost[i].stoim[2];
			 cout << "  Availability of free places for each number:\n";
			 cin >> gost[i].svobmest;
			 cout << "  Number of applications for accommodation in rooms:\n";
			 cin >> gost[i].zayavki;
			 cout << "  Number of days pre-paid per room:\n";
			 cin >> gost[i].kolvodney; cout << endl;
		 }

		 FILE* f_out, * f_in;
		 f_out = fopen(path3, "wb");
		 fwrite(gost, sizeof(gost), n, f_out);
		 fclose(f_out);
		 //delete[] gost;
		 //gost = nullptr;

		 for (int i = 0;i < n;i++)//расчет скидок
		 {
			 if (gost[i].kolvodney >= 10 && gost[i].kolvodney < 20)
			 {
				 for (int j = 0;j < 3;j++)
				 {
					 gost[i].stoim[j] = gost[i].stoim[j] - (gost[i].stoim[j] / 100 * 5);
				 }
			 }

			 if (gost[i].kolvodney >= 20)
			 {
				 for (int j = 0;j < 3;j++)
				 {
					 gost[i].stoim[j] = gost[i].stoim[j] - (gost[i].stoim[j] / 10);
				 }
			 }
		 }

		 f_out = fopen(path3, "wb");
		 fwrite(gost, sizeof(gost), n, f_out);//перезаполнение файла измененным массивом
		 fclose(f_out);

		 Gost* skidki = new Gost[n];
		 f_in = fopen(path3, "rb");
		 fread(skidki, sizeof(Avto), n, f_in);//считывание измененного массива
		 fclose(f_in);

		 for (int i = 0;i < n;i++)//показ изсененного массива
		 {
			 cout << "\n  The name of the hotel:   ";
			 cout << gost[i].nazva << endl;
			 cout << "  The cost of hotel rooms (one-room):   ";
			 cout << gost[i].stoim[0] << endl;
			 cout << "  The cost of hotel rooms (two-room):   ";
			 cout << gost[i].stoim[1] << endl;
			 cout << "  The cost of hotel rooms (three-room):   ";
			 cout << gost[i].stoim[2] << endl;
			 cout << "  Availability of free places for each number:   ";
			 cout << gost[i].svobmest << endl;
			 cout << "  Number of applications for accommodation in rooms:   ";
			 cout << gost[i].zayavki << endl;
			 cout << "  Number of days pre-paid per room:   ";
			 cout << gost[i].kolvodney << endl;
		 }

	 }


	 return 0;
}
