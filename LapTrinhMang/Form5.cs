using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhMang
{
    public partial class Form5: Form
    {
        private static string[] comboBoxItems = ["Decimal", "Binary", "Hexadecimal"];
      
        private Form1 _form1;
        public Form5(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            comboBox1.Items.AddRange(comboBoxItems);
            comboBox2.Items.AddRange(comboBoxItems);
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = null;
            if (comboBox1.Text.Equals(comboBoxItems[0]))
            {
                try
                {
                    if (comboBox2.Text.Equals(comboBoxItems[1]))
                    {
                        output = DecimalToBinary(Int32.Parse(textBox1.Text));
                    }
                    else if (comboBox2.Text.Equals(comboBoxItems[2]))
                    {
                        output = DecimalToHexadecimal(Int32.Parse(textBox1.Text));
                    }
                    else
                    {
                        output = Convert.ToInt32(textBox1.Text).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Hãy nhập một số thập phân!");
                }
               
            }
            else if (comboBox1.Text.Equals(comboBoxItems[1]))
            {
                try
                {
                    if (comboBox2.Text.Equals(comboBoxItems[0]))
                    {
                        output = BinaryToDecimal(textBox1.Text).ToString();
                    }
                    else if (comboBox2.Text.Equals(comboBoxItems[2]))
                    {
                        output = BinaryToHexadecimal(textBox1.Text).ToString();
                    }
                    else output = Convert.ToString(Int32.Parse(textBox1.Text), 2);
                }
                catch
                {
                    MessageBox.Show("Hãy nhập một số nhị phân!");
                }
            }
            else
            {
                try
                {
                    if (comboBox2.Text.Equals(comboBoxItems[0]))
                    {
                        output = HexadecimalToDecimal(textBox1.Text).ToString();
                    }
                    else if (comboBox2.Text.Equals(comboBoxItems[1]))
                    {
                        output = HexadecimalToBinary(textBox1.Text);
                    }
                    else output = Convert.ToString(Int32.Parse(textBox1.Text), 16);
                }
                catch
                {
                    MessageBox.Show("Hãy nhập một số thập lục phân!");
                }
            }
            textBox2.Text = output;
         
        }
        public static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        public static string DecimalToHexadecimal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        public static int HexadecimalToDecimal(string hexNumber)
        {
            return Convert.ToInt32(hexNumber, 16);
        }

        public static string BinaryToHexadecimal(string binaryNumber)
        {
            int decimalValue = Convert.ToInt32(binaryNumber, 2);
            return Convert.ToString(decimalValue, 16).ToUpper();
        }

        public static string HexadecimalToBinary(string hexNumber)
        {
            int decimalValue = Convert.ToInt32(hexNumber, 16);
            return Convert.ToString(decimalValue, 2);
        }
    }
}
