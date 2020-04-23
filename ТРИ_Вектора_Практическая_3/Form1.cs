using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРИ_Вектора_Практическая_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double ax, ay, az, bx, by, bz;
			ax = Convert.ToDouble(textBox1.Text);
			ay = Convert.ToDouble(textBox2.Text);
			az = Convert.ToDouble(textBox3.Text);
			bx = Convert.ToDouble(textBox4.Text);
			by = Convert.ToDouble(textBox5.Text);
			bz = Convert.ToDouble(textBox6.Text);
			Vector vec = new Vector(ax, ay, az, bx, by, bz);
			textBox7.Text = vec.CX(ax, bx).ToString("F3");
			textBox8.Text = vec.CY(ay, by).ToString("F3");
			textBox9.Text = vec.CZ(az, bz).ToString("F3");
			textBox10.Text = vec.AB(ax, ay, az, bx, by, bz).ToString("F3");
			textBox11.Text = vec.BC(ax, ay, az, bx, by, bz).ToString("F3");
			textBox12.Text = vec.AC(ax, ay, az, bx, by, bz).ToString("F3");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = null;
			textBox2.Text = null;
			textBox3.Text = null;
			textBox4.Text = null;
			textBox5.Text = null;
			textBox6.Text = null;
			textBox7.Text = null;
			textBox8.Text = null;
			textBox9.Text = null;
			textBox10.Text = null;
			textBox11.Text = null;
			textBox12.Text = null;
		}
	}
	class Vector 
	{
		
		public Vector()
		{
		}
		public Vector(double ax, double ay, double az, double bx, double by, double bz)
		{		
		}
		  public double CX(double ax, double bx)
		{
			return  (ax + bx) * ax;
		}
		  public double CY(double ay, double by)
		{
			return  (ay + by) * ay;
		}
		  public double CZ(double az, double bz)
		{
			return (az + bz) * az;
		}

		public double AB(double ax, double ay, double az, double bx, double by, double bz)
{
return 57.3*Math.Acos((ax*bx + ay*by + az*bz)/(Math.Sqrt(ax*ax+ay*ay+az*az) * Math.Sqrt(bx * bx + by * by + bz * bz)));
}
        public double BC(double ax, double ay, double az, double bx, double by, double bz)
{
return 57.3*Math.Acos((CX(ax, bx) * bx + CY(ay, by) * by + CZ(az, bz) * bz) / (Math.Sqrt(CX(ax, bx) * CX(ax, bx) + CY(ay, by) * CY(ay, by) + CZ(az, bz) * CZ(az, bz)) * Math.Sqrt(bx * bx + by * by + bz * bz)));
}
        public double AC(double ax, double ay, double az, double bx, double by, double bz)
{
return 57.3*Math.Acos((ax * bx + ay * by + az * bz) / (Math.Sqrt(ax * ax + ay * ay + az * az) * Math.Sqrt(bx * bx + by * by + bz * bz)));
}
	}
	class Ugol : Vector 
	{
	
	}
}
