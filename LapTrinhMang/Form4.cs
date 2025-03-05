using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhMang
{
    public partial class Form4: Form
    {
        private Form1 _form1;

        public Form4(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private static int countDigit(int n)
        {
            if (n == 0)
                return 1;
            int count = 0;
            while (n != 0)
            {
                n = n / 10;

                count++;
            }
            return count;
        }

        private static string readOneNumber(int n)
        {
            switch (n)
            {
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
                default:
                    return "Không";

            }
        } 

        private static string readTwoNumber(int n)
        {
            string output = "";
            switch (n / 10)
            {
                case 1:
                    output += "Mười ";
                    break;
                case 2:
                    output += "Hai Mươi ";
                    break;
                case 3:
                    output += "Ba Mươi ";
                    break;
                case 4:
                    output += "Bốn Mươi ";
                    break;
                case 5:
                    output += "Năm Mươi ";
                    break;
                case 6:
                    output += "Sáu Mươi ";
                    break;
                case 7:
                    output += "Bảy Mươi ";
                    break;
                case 8:
                    output += "Tám Mươi ";
                    break;
                case 9:
                    output += "Chín Mươi ";
                    break;
                default:
                    break;
            }
            output += readOneNumber(n % 10);
            return output;
        }

        private static string readThreeNumber(int n)
        {
            string output = "";
            switch (n / 100)
            {
                case 1:
                    output += "Một Trăm ";
                    break;
                case 2:
                    output += "Hai Trăm ";
                    break;
                case 3:
                    output += "Ba Trăm ";
                    break;
                case 4:
                    output += "Bốn Trăm ";
                    break;
                case 5:
                    output += "Năm Trăm ";
                    break;
                case 6:
                    output += "Sáu Trăm ";
                    break;
                case 7:
                    output += "Bảy Trăm ";
                    break;
                case 8:
                    output += "Tám Trăm ";
                    break;
                case 9:
                    output += "Chín Trăm ";
                    break;
                default:
                    break;
            }
            output += readTwoNumber(n % 100);
            return output;
        }

        private static string readFourNumber(int n)
        {
            string output = "";
            switch (n / 1000)
            {
                case 1:
                    output += "Một Nghìn ";
                    break;
                case 2:
                    output += "Hai Nghìn ";
                    break;
                case 3:
                    output += "Ba Nghìn ";
                    break;
                case 4:
                    output += "Bốn Nghìn ";
                    break;
                case 5:
                    output += "Năm Nghìn ";
                    break;
                case 6:
                    output += "Sáu Nghìn ";
                    break;
                case 7:
                    output += "Bảy Nghìn ";
                    break;
                case 8:
                    output += "Tám Nghìn ";
                    break;
                case 9:
                    output += "Chín Nghìn ";
                    break;
                default:
                    break;
            }
            output += readThreeNumber(n % 1000);
            return output;
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            int input;
            try
            {
                input = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Hãy nhập một số!");
                return;
            }
           
            switch (countDigit(input))
            {
                case 1:
                    textBox2.Text = readOneNumber(input);
                    break;
                case 2:
                    textBox2.Text = readTwoNumber(input);
                    break;
                case 3:
                    textBox2.Text = readThreeNumber(input);
                    break;
                default:
                    textBox2.Text = readFourNumber(input);
                    break;
            }
            ;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _form1.Show();
        }
    }
}
