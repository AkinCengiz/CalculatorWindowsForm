using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		decimal result = 0;
		public string number = "0";
		char operation = ' ';
		#region NumerikKontrolElemanlari
		private void btn7_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn7.Text);
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn9.Text);
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn8.Text);
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn6.Text);
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn5.Text);
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn4.Text);
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn3.Text);
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn2.Text);
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			TextNumberdegerGir(btn1.Text);
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			if (number != "0")
			{
				TextNumberdegerGir(btn0.Text);
			}
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			if (!number.Contains(","))
			{
				if (number == "")
				{
					number = "0";
				}
				TextNumberdegerGir(btnDot.Text);
			}
		} 
		#endregion

		private void btnDivide_Click(object sender, EventArgs e)
		{
			IslemYap(operation);
			operation = '/';
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			number = "";
			result = 0;
			txtNumber.Text = number;
			lblResult.Text = result.ToString();
			groupBox1.Enabled = true;
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			IslemYap(operation);
			operation = '*';
		}

		private void btnSubtract_Click(object sender, EventArgs e)
		{
			IslemYap(operation);
			operation = '-';
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			IslemYap(operation);
			operation = '+';
		}

		

		private void btnResult_Click(object sender, EventArgs e)
		{
			IslemYap(operation);
			operation = ' ';
			groupBox1.Enabled = false;
		}

		void TextNumberdegerGir(string sayi)
		{
			if (number == "0" && sayi != "." )
			{
				number = "";
			}
			number += sayi;
			txtNumber.Text = number;

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtNumber.Text = number;
		}

		private void txtNumber_TextChanged(object sender, EventArgs e)
		{
			if (txtNumber.Text == "")
			{
				number = "0";
				txtNumber.Text = number.ToString();
				txtNumber.SelectionStart = txtNumber.Text.Length;
				
			}
			else
			{
				number = txtNumber.Text;
			}
		}

		decimal IslemYap(char islem)
		{
			
			switch (islem)
			{
				case '+':
					result += Convert.ToDecimal(number);
					break;
				case '-':
					result -= Convert.ToDecimal(number);
					break;
				case '*':
					if (result == 0)
					{
						result = 1;
					}
					result *= Convert.ToDecimal(number);
					break;
				case '/':
					try
					{
						result /= Convert.ToDecimal(number);
					}
					catch (Exception)
					{
						MessageBox.Show("Bölen 0 olamaz...");
					}
					break;
				case ' ':
					result = Convert.ToDecimal(number);
					number = "";
					txtNumber.Clear();
					break;
			}
			txtNumber.Clear();
			if (result % 1 == 0)
			{
				lblResult.Text = result.ToString();
			}
			else
			{
				lblResult.Text = result.ToString("0.00");
			}
			return result;
		}
	}

	
}
