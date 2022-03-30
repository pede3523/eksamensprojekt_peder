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
    public partial class Form_Procent_task : Form
    {
        double rightanswer = 0.0;
        double rightanswer2 = 0.0;
        public Form_Procent_task()
        {
            InitializeComponent();
            Random random1 = new Random();
            double num1 = random1.Next(0, 100);
            double num2 = random1.Next(0, 100);
            double num3 = random1.Next(0, 100);
            double num4 = random1.Next(0, 100);
            double num5 = random1.Next(0, 100);
            rightanswer = Math.Round((num1 / 100) * num2, 1);
            rightanswer2 = Math.Round(((num3 / 100) * num4) + ((num5 / 100) * num4));
            label_tal.Text = "what is " + num2.ToString() + "% of " + num1.ToString();
            label_tal2.Text = "how does " + num3 + " and " + num5 + " with a discount of" + num4 + " = ";
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_answer.Text) != rightanswer) // hvis svaret er forkert bliver knappen rød
                {
                        textBox_answer.BackColor = Color.Red;
                        label_answer.Text = "Forkert. Prøv igen";
                        label_answer.Visible = true;
                }
                else if (double.Parse(textBox_answer.Text) == rightanswer) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_answer.BackColor = Color.LightGreen;
                    label_answer.Text = "Dit svaret er rigtig";
                    label_answer.Visible = true;
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

        private void button_answer2_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_answer2.Text) != rightanswer) // hvis svaret er forkert bliver knappen rød
                {
                    textBox_answer2.BackColor = Color.Red;
                    label_answer2.Text = "Forkert. Prøv igen";
                    label_answer2.Visible = true;
                }
                else if (double.Parse(textBox_answer2.Text) == rightanswer) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_answer2.BackColor = Color.LightGreen;
                    label_answer2.Text = "Dit svaret er rigtig";
                    label_answer2.Visible = true;
                }
            }
            catch (Exception)
            {
                Color c = textBox_answer2.BackColor;
                textBox_answer2.BackColor = Color.Red;
                MessageBox.Show("Error! you have to enter an number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_answer2.BackColor = c;
                textBox_answer2.Text = "";
                textBox_answer2.Focus();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_Procent fp = new Form_Procent();
            fp.Show();
            this.Close();
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
