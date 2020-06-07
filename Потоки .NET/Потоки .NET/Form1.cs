using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Потоки.NET
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.CenterToScreen();

			var column1 = new DataGridViewColumn();
			column1.HeaderText = "Сложение"; //текст в шапке
			column1.Width = 100; //ширина колонки
			//column1.ReadOnly = true; //значение в этой колонке нельзя править
			column1.Name = "sloj"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
			column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
			column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

			var column2 = new DataGridViewColumn();
			column2.HeaderText = "Умножение"; //текст в шапке
			column2.Width = 100; //ширина колонки
			//column2.ReadOnly = true; //значение в этой колонке нельзя править
			column2.Name = "umnoj"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
			column2.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
			column2.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

			var column3 = new DataGridViewColumn();
			column3.HeaderText = "Возведение в степень"; //текст в шапке
			column3.Width = 200; //ширина колонки
			//column3.ReadOnly = true; //значение в этой колонке нельзя править
			column3.Name = "stepen"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
			column3.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
			column3.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

			dataGridView1.Columns.Add(column1);
			dataGridView1.Columns.Add(column2);
			dataGridView1.Columns.Add(column3);

		}



		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 48 || e.KeyChar >= 54) && (e.KeyChar <= 07 || e.KeyChar >= 09))
			{
				e.Handled = true;
			}
			textBox1.MaxLength = 1;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 48 || e.KeyChar >= 54) && (e.KeyChar <= 07 || e.KeyChar >= 09))
			{
				e.Handled = true;
			}
			textBox1.MaxLength = 1;
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 48 || e.KeyChar >= 54) && (e.KeyChar <= 07 || e.KeyChar >= 09))
			{
				e.Handled = true;
			}
			textBox1.MaxLength = 1;
		}

		static object loker = new object();
		public void mythread1(){

			
			for (int i = 1; i <= 512; i++)
				{lock (loker)
			{
					dataGridView1.Rows.Add(i * 2, "", "");
				}
			}
		}
		public void mythread2(){
			
				int a = 1;
				for (int i = 0; i < 10; i++)
				{lock (loker)
			{
					a = a * 2;
					dataGridView1.Rows.Add("", a, "");
				}
			}
		}
		public void mythread3()
		{
			lock (loker)
			{
				int a = 2;
				double b;
				b = Math.Pow(a, 10);
				dataGridView1.Rows.Add("", "", b);
			}
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
			Thread thread1 = new Thread(mythread1);
			if (textBox1.Text != "")
			{
				int prior1 = Convert.ToInt32(textBox1.Text);
				if (prior1 == 1) thread1.Priority = ThreadPriority.Highest;
				if (prior1 == 2) thread1.Priority = ThreadPriority.AboveNormal;
				if (prior1 == 3) thread1.Priority = ThreadPriority.Normal;
				if (prior1 == 4) thread1.Priority = ThreadPriority.BelowNormal;
				if (prior1 == 5) thread1.Priority = ThreadPriority.Lowest;
			}
			thread1.Start();
			textBox1.Text = "";

			Thread thread2 = new Thread(mythread2);
			if (textBox2.Text != "")
			{
				int prior2 = Convert.ToInt32(textBox2.Text);
				if (prior2 == 1) thread2.Priority = ThreadPriority.Highest;
				if (prior2 == 2) thread2.Priority = ThreadPriority.AboveNormal;
				if (prior2 == 3) thread2.Priority = ThreadPriority.Normal;
				if (prior2 == 4) thread2.Priority = ThreadPriority.BelowNormal;
				if (prior2 == 5) thread2.Priority = ThreadPriority.Lowest;
			}
			thread2.Start();
			textBox2.Text = "";

			Thread thread3 = new Thread(mythread3);
			if (textBox3.Text != "")
			{
				int prior3 = Convert.ToInt32(textBox3.Text);
				if (prior3 == 1) thread3.Priority = ThreadPriority.Highest;
				if (prior3 == 2) thread3.Priority = ThreadPriority.AboveNormal;
				if (prior3 == 3) thread3.Priority = ThreadPriority.Normal;
				if (prior3 == 4) thread3.Priority = ThreadPriority.BelowNormal;
				if (prior3 == 5) thread3.Priority = ThreadPriority.Lowest;
			}
			thread3.Start();
			textBox3.Text = "";




		}
	}
}
