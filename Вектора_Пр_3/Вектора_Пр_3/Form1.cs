using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вектора_Пр_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			double a1, a2, a3, b1, b2, b3, c1, c2, c3, a, b, c, v, u1, u2, u3;
			v = double.Parse(textBox2.Text);
			a1 = v;
			v = double.Parse(textBox3.Text);
			a2 = v;
			v = double.Parse(textBox4.Text);
			a3 = v;
			v = double.Parse(textBox5.Text);
			b1 = v;
			v = double.Parse(textBox6.Text);
			b2 = v;
			v = double.Parse(textBox7.Text);
			b3 = v;
			a = Math.Sqrt(a1 * a1 + a2 * a2 + a3 * a3);
			b = Math.Sqrt(b1 * b1 + b2 * b2 + b3 * b3);
			c1 = (a1 + b1) * a1;
			c2 = (a2 + b2) * a2;
			c3 = (a3 + b3) * a3;
			c = Math.Sqrt(c1 * c1 + c2 * c2 + c3 * c3);
			textBox8.Text = a.ToString("F2");
			textBox1.Text = b.ToString("F2");
			textBox9.Text = c.ToString("F2");
			//Math.Acos
			u1 = (180 / Math.PI) * Math.Acos((a1 * b1 + a2 * b2 + a3 * b3) / (Math.Sqrt(a1 * a1 + a2 * a2 + a3 * a3) * Math.Sqrt(b1 * b1 + b2 * b2 + b3 * b3)));
			textBox10.Text = u1.ToString("F2");
			u2 = (180 / Math.PI) * Math.Acos((c1 * b1 + c2 * b2 + c3 * b3) / (Math.Sqrt(c1 * c1 + c2 * c2 + c3 * c3) * Math.Sqrt(b1 * b1 + b2 * b2 + b3 * b3)));
			textBox11.Text = u2.ToString("F2");
			u3 = (180 / Math.PI) * Math.Acos((c1 * a1 + c2 * a2 + c3 * a3) / (Math.Sqrt(c1 * c1 + c2 * c2 + c3 * c3) * Math.Sqrt(a1 * a1 + a2 * a2 + a3 * a3)));
			textBox12.Text = u3.ToString("F2");

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
			textBox11.Clear();
			textBox12.Clear();
		}
	}
}
