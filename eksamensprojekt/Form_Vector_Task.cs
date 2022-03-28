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
    public partial class Form_Vector_Task : Form
    {
        double rightanswer = 0.0;
        double rightanswerplus1 = 0.0;
        double rightanswerplus2 = 0.0;
        public Form_Vector_Task()
        {
            InitializeComponent();
            Random random1 = new Random();
            int num1 = random1.Next(0, 50);
            int num2 = random1.Next(0, 50);
            int num3 = random1.Next(0, 50);
            int num4 = random1.Next(0, 50);
            int num5 = random1.Next(0, 50);
            int num6 = random1.Next(0, 50);
            rightanswer = Math.Round(Math.Sqrt((num1 * num1) + (num2 * num2))); // regner det rigtige svar.
            rightanswerplus1 = (num3 + num4);
            rightanswerplus2 = (num5 + num6);
            label_tal.Text = "(" + num1.ToString() + ","+ num2.ToString() + ")";
            label_tal2.Text = "(" + num3.ToString() + "," + num4.ToString() + ") + (" + num5 + "," + num6 + ")";
        }

        private void button_Fin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Visible = false;
            f.Show();
            this.Close();
            
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Vector fv = new Form_Vector();
            fv.Show();
            this.Close();
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
            catch // fanger hvis man skriver et bogstav.
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
            string[] answerarray = textBox_answer2.Text.Split(new char[] { ',' });
            
        }
    }
}
