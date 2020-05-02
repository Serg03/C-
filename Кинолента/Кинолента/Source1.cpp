﻿#include <fstream>
#include <string>
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;
int main()
{
    setlocale(LC_ALL, "rus");

    cout << "Чтобы запустилось первое задание, нажмите 1 ";
    int q;
    while (true)
    {
       cin >> q;
        if (!cin)
        {
            cout << "*Повторите ввод: \n";
            cin.clear();
            while (cin.get() != '\n');
        }
        else break;
    }
    
    if (q == 1)
    {
        cout << "\tВыполнил Решетняк Сергей, АТ-191\nПри открытии текстового файла, програма будет остановлена, до тех пор, пока фйл не будет закрыт" << endl;
        cout << "\tБАЗОВЫЙ УРОВЕНЬ\nCоздать текстовый файл с произвольной информацией. Организовать    просмотр  содержимого  файла.  Организовать  чтение  и  обработку данных  из  файла в  соответствии  с  индивидуальным  заданием.  Сохранить полученные результаты в новый текстовый файл." << endl;
        cout << "14)Условия:  «Кинолента»:название; режиссер (фамилия; имя); год выхода; страна; стоимость; доход; прибыль. Вывести данные про фильмы режиссера Ежи Гофмана." << endl;

        ifstream in("kinolenta1.txt");
        ofstream out("kinolenta2.txt");
        out << "*** Фильмы, снятые Ежи Гофманом ***\n" << endl;
        struct Kino
        {
            string nazva, ima, famlilia, strana, god, stoim, dohod, pribyl;
        };
        cout << "Показ изначального файла (при редактировании прямо сейчас, на работу программы это не повлияет) " << endl;
        system("kinolenta1.txt");
        cout << endl;
        Kino p[4];
        int i = 0, y = 0;

        while (!in.eof())
        {
            in >> p[i].nazva;      cout << "Название фильма: " << "<<" << p[i].nazva << ">>" << endl;
            in >> p[i].famlilia;   cout << "Фамилия пежисёра: " << p[i].famlilia << endl;
            in >> p[i].ima;        cout << "Имя режисёра: " << p[i].ima << endl;
            in >> p[i].god;        cout << "Год создания: " << p[i].god << endl;
            in >> p[i].strana;     cout << "Страна: " << p[i].strana << endl;
            in >> p[i].stoim;      cout << "Стоимость: " << p[i].stoim << endl;
            in >> p[i].dohod;      cout << "Доход: " << p[i].dohod << endl;
            in >> p[i].pribyl;     cout << "Прибыль: " << p[i].pribyl << endl;
            i++; cout << endl;
        }

        for (i = 0;i < 4;i++) {
            if ((p[i].famlilia == "Гофман") && (p[i].ima == "Ежи")) {
                y++;
                out << y << ") Название фильма: " << "<<" << p[i].nazva << ">>" << endl;
                out << "Год создания: " << p[i].god << endl;
                out << "Страна: " << p[i].strana << endl;
                out << "Стоимость: " << p[i].stoim << endl;
                out << "Доход: " << p[i].dohod << endl;
                out << "Прибыль: " << p[i].pribyl << "\n" << endl;
            }
        }
        in.close();
        out.close();
        system("kinolenta2.txt");
    }


    cout << "Чтобы запустилось второе задание, нажмите 2 ";
    while (true)
    {
        cin >> q;
        if (!cin)
        {
            cout << "*Повторите ввод: \n";
            cin.clear();
            while (cin.get() != '\n');
        }
        else break;
    }
    if (q == 2)
    {
        cout << "\tСРЕДНИЙ УРОВЕНЬ\n Задание: создать текстовый файл в текстовом редакторе. Организовать просмотр содержимого файла и выполнения действий в соответствии с условием индивидуального задания.\n Обеспечить сохранение всех полученных результатов в новый файл." << endl;
        cout << " 14)Условия: Дан файл f, компоненты которого являются действительными числами. Найти наибольшее из значений модулей компонент с нечётными номерами." << endl;
        ifstream in("f.txt");
        ofstream out("fmax.txt");
        cout << "Показ изначального файла (при редактировании прямо сейчас, на работу программы это не повлияет) " << endl;
        system("f.txt");

        string s;
        double a, max = -9999;
        int i = 1;
        cout << "\tЧисла из файла:" << endl;

        while (!in.eof())
        {
            in >> s;
            a = atof(s.c_str());
            cout << a << " ";
            a = abs(a);
            s = "";
            if (i / 2 == 0) { if (max < a) max = a; }
        }
        out << "\t **Наибольшим по модулю числом является: **\n\t\t\n\t\t**  ";
        out << max << "  **";
        out.close();
        system("fmax.txt");
    }


    cout << "\n\nЧтобы запустилось третье задание, нажмите 3 ";
    while (true)
    {
        cin >> q;
        if (!cin)
        {
            cout << "*Повторите ввод: \n";
            cin.clear();
            while (cin.get() != '\n');
        }
        else break;
    }
    if (q == 3)
    {
        ifstream kin("k.txt");
        ifstream lin("l.txt");
        ofstream out("T.txt");
        ofstream kout("k2.txt");
        ofstream lout("l2.txt");
        int m, n, k, l, d;
        cout << "\tВЫСОКИЙ УРОВЕНЬ\n В первом файле хранится k (k <= 10)матриц размерности m x n(m, n <= 10), во втором l (l <= 10) матриц размерности m × n. Убрать из файла, в котором меньше матриц, лишние матрицы в третий файл. Вывести на экран содержимое первого файла; второго файла; третьего файла." << endl;
        cout << "Введите количество столбцов m: " << endl;
        cin >> m;
        cout << "Введите количество строк n: " << endl;
        cin >> n;
        cout << "Введите количество массивов k: " << endl;
        cin >> k;
        cout << "Введите количество массивов l: " << endl;
        cin >> l;
        cout << "Показ изначальных файлов (при редактировании прямо сейчас, на работу программы это не повлияет) " << endl;
        cout << "Можно изменить элементы массивов k и l (вводить эл-ты через пробел)" << endl;
        system("k.txt");
        system("l.txt");
        double fk[10][10][10], fl[10][10][10];
        int w; w = k - l; w = abs(w);

        for (int y = 0;y < k;y++) {
            for (int j = 0;j < n;j++) {
                for (int i = 0;i < m;i++) {
                    kin >> fk[y][j][i];
                }
            }
        }

        for (int y = 0;y < l;y++) {
            for (int j = 0;j < n;j++) {
                for (int i = 0;i < m;i++) {
                    lin >> fl[y][j][i];
                }
            }
        }

        if (k == l)
        {
            for (int y = 0;y < k;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        kout << fk[y][j][i] << " ";
                    }kout << endl;
                }kout << endl;
            }
            for (int y = 0;y < l;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        lout << fl[y][j][i] << " ";
                    }lout << endl;
                }lout << endl;
            }
            out << "\t** Количество массивов в файлах одинаково **";
        }
        else if (k > l)
        {
            for (int y = 0;y < k - w;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        kout << fk[y][j][i] << " ";
                    }kout << endl;
                }kout << endl;
            }
            for (int y = k - w;y < k;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        out << fk[y][j][i] << " ";
                    }out << endl;
                }out << endl;
            }
            for (int y = 0;y < l;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        lout << fl[y][j][i] << " ";
                    }lout << endl;
                }lout << endl;
            }
        }
        else
        {
            for (int y = 0;y < l - w;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        lout << fl[y][j][i] << " ";
                    }lout << endl;
                }lout << endl;
            }
            for (int y = l - w;y < l;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        out << fl[y][j][i] << " ";
                    }out << endl;
                }out << endl;
            }
            for (int y = 0;y < k;y++) {
                for (int j = 0;j < n;j++) {
                    for (int i = 0;i < m;i++) {
                        kout << fk[y][j][i] << " ";
                    }kout << endl;
                }kout << endl;
            }
        }

        out.close(); kout.close(); lout.close();
        system("k2.txt");
        system("l2.txt");
        system("T.txt");
    }
return 0;
}
