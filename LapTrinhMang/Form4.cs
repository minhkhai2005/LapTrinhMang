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
            string output;
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

        }

        private static string readThreeNumber(int n)
        {

        }

        private static string readFourNumber(int n)
        {

        };

        private void readButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            switch (countDigit(input))
            {
                case 1:
                    break;

            }
            ;
        }
    }
}
