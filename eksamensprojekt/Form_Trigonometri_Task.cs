using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eksamensprojekt
{
    public partial class Form_Trigonometri_Task : Form
    {
        double rightanswer = 0.0;
        double rightanswer2 = 0.0;
        public Form_Trigonometri_Task()
        {
            InitializeComponent();
            Random random1 = new Random();
            int num1 = random1.Next(0, 50);
            int num2 = random1.Next(0, 89);
            int num3 = random1.Next(0, 50);
            int num4 = random1.Next(0, 50);

            rightanswer = Math.Round(num1/Math.Sin(num2));
            rightanswer2 = Math.Round(Math.Asin(num3/num4));
            label_tal.Text = "lenght a = " + num1.ToString() + "*. angle a = " + num2.ToString() + ". c =";
            label_tal2.Text = "a = " + num3.ToString() + ". b = " + num4.ToString() + ". angle a = ";
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_answer.Text) != rightanswer) // hvis svaret er forkert bliver knappen rød
                {
                    textBox_answer.BackColor = Color.Red;
                    label_answer.Text = "Forkert. Prøv igen";
                }
                else if (double.Parse(textBox_answer.Text) == rightanswer) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_answer.BackColor = Color.LightGreen;
                    label_answer.Text = "Dit svaret er rigtig";
                }
            }
            catch (Exception)
            {
                Color c = textBox_answer.BackColor;
                textBox_answer.BackColor = Color.Red;
                MessageBox.Show("Error! you have to enter an number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_answer.BackColor = c;
                textBox_answer.Text = "";
                textBox_answer.Focus();
            }
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Trigonometri ft = new Form_Trigonometri();
            ft.Show();
            this.Close();
        }

        private void button_answer2_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_answer2.Text) != rightanswer2) // hvis svaret er forkert bliver knappen rød
                {
                    textBox_answer.BackColor = Color.Red;
                    label_answer2.Text = "Forkert. Prøv igen";
                }
                else if (double.Parse(textBox_answer2.Text) == rightanswer2) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_answer.BackColor = Color.LightGreen;
                    label_answer2.Text = "Dit svaret er rigtig";
                }
            }
            catch (Exception)
            {
                Color c = textBox_answer.BackColor;
                textBox_answer.BackColor = Color.Red;
                MessageBox.Show("Error! you have to enter an number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_answer.BackColor = c;
                textBox_answer.Text = "";
                textBox_answer.Focus();
            }
        }

    }
}
