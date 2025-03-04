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
    public partial class Form3: Form
    {
        private Form1 _form1;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<decimal> inputs = new List<decimal>();
                inputs.Add(Convert.ToDecimal(input1.Text));
                inputs.Add(Convert.ToDecimal(input2.Text));
                inputs.Add(Convert.ToDecimal(input3.Text));
                decimal largestNumber = inputs.Max();
                decimal smallestNumber = inputs.Min();
                largestOutput.Text = largestNumber.ToString();
                smallestOutput.Text = smallestNumber.ToString();
            }
            catch
            {
                MessageBox.Show("Hãy nhập số!");
            }
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            input1.Text = input2.Text = input3.Text = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _form1.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            _form1.Show();
        }
    }
}
