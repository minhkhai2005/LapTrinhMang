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
    public partial class Form6: Form
    {
        private static Form1 _form1;
        public Form6(Form1 f1)
        {
            InitializeComponent();
            _form1 = f1;
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subject2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subject1_Click(object sender, EventArgs e)
        {

        }

        private void printScore(string[] scoreList)
        {
            if (scoreList.Length != 12) return;
            score1.Text = scoreList[0];
            score2.Text = scoreList[1];
            score3.Text = scoreList[2];
            score4.Text = scoreList[3];
            score5.Text = scoreList[4];
            score6.Text = scoreList[5];
            score7.Text = scoreList[6];
            score8.Text = scoreList[7];
            score9.Text = scoreList[8];
            score10.Text = scoreList[9];
            score11.Text = scoreList[10];
            score12.Text = scoreList[11];
        }

        private static string getGrade(double[] scoreList, double avg)
        {
            string grade = "Kém";
            if (avg >= 8 && scoreList.Count(s => s < 6.5) == 0)
            {
                grade = "Giỏi";
            }
            else if (avg >= 6.5 && scoreList.Count(s => s < 5) == 0)
            {
                grade = "Khá";
            }
            else if (avg >= 5 && scoreList.Count(s => s < 3.5) == 0)
            {
                grade = "TB";
            }
            else if (avg >= 3.5 && scoreList.Count(s => s < 2) == 0)
            {
                grade = "Yếu";
            }
                return grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] scoreList = textBox1.Text.Split(',');
            double[] scoreListDouble = new double[12];
            if (scoreList.Length != 12)
            {
                MessageBox.Show("Hãy nhập 12 số điểm!");
                return;
            }
            try
            {
                for (int i = 0;i < 12; i++)
                {
                    scoreListDouble[i] = double.Parse(scoreList[i]);
                }
            }
            catch
            {
                MessageBox.Show("Điểm nhập vào không hợp lệ!");
                return;
            }
            printScore(scoreList);
            highestOutput.Text = scoreListDouble.Max().ToString();
            avgOutput.Text = Math.Round(scoreListDouble.Average(), 2).ToString();
            passedOutput.Text = scoreListDouble.Count(s => s >= 5.0).ToString();
            gradeOutput.Text = getGrade(scoreListDouble, scoreListDouble.Average());
            lowestOutput.Text = scoreListDouble.Min().ToString();
            notPassedOutput.Text = scoreListDouble.Count(s => s < 5).ToString();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
    }
}
