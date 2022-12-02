using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double f(double number)
		{
			return (number % 5 == 0) ? number / 5 : number + 1;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double number = double.Parse(textBox1.Text);
				double res = f(number);
				textBox2.Text = string.Format("{0}", res);
			}
			catch
			{
				textBox3.Text = string.Format("Введены некорректные данные.");
			}
			
		}
	}
}
