using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _4_Лаба_сделанная_из_2_Б_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private double sok = 0, soc = 0, srk, src, ik = 0, ic = 0;
        private string strk1, strk2, strc1, strc2, str;

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt) | *.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                str = ofd.FileName;
                string[] mass_str = File.ReadAllLines(str, Encoding.Default);
                textBox11.Text = mass_str[0];
                textBox12.Text = mass_str[1];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.FileName = "Save_inf_cub.txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "txt files (*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream file = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(strc1 + "\n" + strc2);
                sw.Close();
                file.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             double a;

             a = Convert.ToDouble(textBox7.Text);
          
            if (a != 0)
            {
                Cub cu = new Cub(a);
                soc += cu.S();
                ic++;
                src = soc / ic;
                textBox8.Text = cu.V().ToString();
                textBox9.Text = cu.P().ToString();
                textBox10.Text = cu.S().ToString();
                textBox11.Text = ic.ToString();
                textBox12.Text = src.ToString();
                strc1 = textBox11.Text;
                strc2 = textBox12.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
		{
            double a;
            double[] b = new double[2];
            
            a = Convert.ToDouble(textBox1.Text);
            
            if (a != 0)
            {
                Kv kvadrat = new Kv(a);
                textBox2.Text = kvadrat.S().ToString();
                sok += kvadrat.S();
                ik++;
                srk = sok / ik;
                
                textBox3.Text = kvadrat.P().ToString();
                textBox4.Text = kvadrat.D().ToString();
                textBox5.Text = ik.ToString();
                textBox6.Text = srk.ToString();
                strk1 = textBox5.Text;
                strk2 = textBox6.Text;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
              
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt) | *.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                str = ofd.FileName;
                string[] mass_str = File.ReadAllLines(str, Encoding.Default);
                textBox5.Text = mass_str[0];
                textBox6.Text = mass_str[1];
            }

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.FileName = "Save_inf_kvadrat.txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "txt files (*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                Stream file = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(strk1 + "\n" + strk2);
                sw.Close();
                file.Close();
            }
        }

       
    }
    class Kv
    {
        public double a, st;

        public Kv()
        {
            a = 0;
        }

        public Kv(double a)
        {
            st = a;
        }

        public double St
        {
            get { return st; }
            set { st = value; }
        }

        public virtual double S()
        {
            return st * st;
        }

        public virtual double P()
        {
            return 4 * st;
        }

        public double D()
        {
            return Math.Sqrt(2 * st * st);
        }
    }

    class Cub : Kv
    {
        public Cub()

        {
            st = 0;
        }

        public Cub(double a)
        {
            st = a;
        }

        public override double S()//площадь куба
        {
            return base.S() * 6;
        }
        public override double P()//пeриметр куба
        {
            return base.P() * 3;
        }

        public double V()
        {
            return st * st * st;
        }

    }
}
