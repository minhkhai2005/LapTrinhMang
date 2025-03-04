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
    public partial class Form2: Form
    {
        private Form1 _form1;
        public Form2 (Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                {
                    output.Text = Convert.ToString(Int32.Parse(input1.Text) + Int32.Parse(input2.Text));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
           
        }

        private void input2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                {
                    output.Text = Convert.ToString(Int32.Parse(input1.Text) + Int32.Parse(input2.Text));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void input1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                {
                    output.Text = Convert.ToString(Int32.Parse(input1.Text) + Int32.Parse(input2.Text));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = Convert.ToString(Int32.Parse(input1.Text) + Int32.Parse(input2.Text));
            }
            catch (Exception exc)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            output.Text = input1.Text = input2.Text = "";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận thoát chương trình?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                _form1.Show();
            }
            else { }
        }
    }
}
