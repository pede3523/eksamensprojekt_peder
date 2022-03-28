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
    public partial class Form_Geomatri_task : Form
    {
        int spørgsmål = 0;
        double rightanswer = 0.0;
        double rightanswerplus1 = 0.0;
        double rightanswerplus2 = 0.0;
        public Form_Geomatri_task()
        {
            InitializeComponent();
            Random random1 = new Random();
            int num1 = random1.Next(0, 50);
            int num2 = random1.Next(31,120); // er større end num3 fordi hypotinosen må være større end kateten
            int num3 = random1.Next(15, 30);
            int num4 = random1.Next(0, 150); //areal skal være større end længder
            int num5 = random1.Next(6, 10); // forskellige længder så vi er sikker på at det ikke bliver rektangel
            int num6 = random1.Next(0, 5);
            double mellemregning = num5 + num6;
            rightanswer = Math.Round(Math.PI * 2 * num1, 1);
            rightanswerplus1 = Math.Round(Math.Sqrt(Math.Pow(num2, 2) - Math.Pow(num3, 2)), 1);
            rightanswerplus2 = Math.Round(2.0 * (num4 /mellemregning), 1); /*2.0 fordi vis ikke kommer en error der sikker at Math.Round er ambiguous
            between Math.Round(double,int) og Math.Round(decimal,int) */
            label_TASK.Text = "Du har en cirkel med radius " + num1.ToString() + " hvad er omkredsen?";
            label_Task1.Text = "Du har en hypotinose på " + num2.ToString() + " og en katete på " + num3.ToString(); ;
            label_Task2.Text = "Find højden på et trapez med areal " + num4.ToString() + " og længder på " + num5.ToString() + " og " + num6.ToString(); ; 

        }

        private void button_finish_Click(object sender, EventArgs e)
        {

        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_Answer.Text) != rightanswer) // hvis svaret er forkert bliver knappen rød
                {
                    textBox_Answer.BackColor = Color.Red;
                    label_Answer.Text = "Forkert. Prøv igen";
                    label_Answer.Visible = true;
                }
                else if (double.Parse(textBox_Answer.Text) == rightanswer) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_Answer.BackColor = Color.LightGreen;
                    label_Answer.Text = "Dit svaret er rigtig";
                    label_Answer.Visible = true;
                    spørgsmål++;
                }
            }
            catch // fanger hvis man skriver et bogstav.
            {
                Color c = textBox_Answer.BackColor;
                textBox_Answer.BackColor = Color.Red;
                MessageBox.Show("Error! you have to enter an number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Answer.BackColor = c;
                textBox_Answer.Text = "";
                textBox_Answer.Focus();
            }
        }

        private void button_Answer1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_Answer1.Text) != rightanswerplus1) // hvis svaret er forkert bliver knappen rød
                {
                    textBox_Answer1.BackColor = Color.Red;
                    label_Answer1.Text = "Forkert. Prøv igen";
                    label_Answer1.Visible = true;
                }
                else if (double.Parse(textBox_Answer1.Text) == rightanswerplus1) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_Answer1.BackColor = Color.LightGreen;
                    label_Answer1.Text = "Dit svaret er rigtig";
                    label_Answer1.Visible = true;
                    spørgsmål++;
                }
            }
            catch // fanger hvis man skriver et bogstav.
            {
                Color c = textBox_Answer.BackColor;
                textBox_Answer1.BackColor = Color.Red;
                MessageBox.Show("Error! you have to enter an number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Answer1.BackColor = c;
                textBox_Answer1.Text = "";
                textBox_Answer1.Focus();

            }
        }

        private void button_Answer2_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox_Answer2.Text) != rightanswerplus2) // hvis svaret er forkert bliver knappen rød
                {
                    textBox_Answer2.BackColor = Color.Red;
                    label_Answer2.Text = "Forkert. Prøv igen";
                    label_Answer2.Visible = true;
                }
                else if (double.Parse(textBox_Answer2.Text) == rightanswerplus2) // hvis svaret er rigtig bliver knappen grøn
                {
                    textBox_Answer2.BackColor = Color.LightGreen;
                    label_Answer2.Text = "Dit svaret er rigtig";
                    label_Answer2.Visible = true;
                    spørgsmål++;
                }
            }
            catch // fanger hvis man skriver et bogstav.
            {
                Color c = textBox_Answer2.BackColor;
                textBox_Answer2.BackColor = Color.Red;
                MessageBox.Show("Error! you have to enter an number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Answer2.BackColor = c;
                textBox_Answer2.Text = "";
                textBox_Answer2.Focus();

            }

        }

        int sekunder = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekunder++;
            label_Timer.Text = sekunder + " sekunder";
            if (spørgsmål == 3)
            {
                timer1.Stop();
                MessageBox.Show("Du har klaret alle spørgsmål på" + sekunder + "sekunder");
            }
        }
    }
}
