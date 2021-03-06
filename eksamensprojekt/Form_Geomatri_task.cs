using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace eksamensprojekt
{
    public partial class Form_Geomatri_task : Form
    {
        int spørgsmål = 0; // variabel som holder styr på hvor mange spørgsmål man har svaret rigtig på 
        double rightanswer = 0.0;
        double rightanswerplus1 = 0.0;
        double rightanswerplus2 = 0.0;
        Form f;

        public Form_Geomatri_task(Form f)
        {
            InitializeComponent();
            this.f = f;
        }
        public Form_Geomatri_task()
        {
            InitializeComponent();
            Random random1 = new Random();
            int num1 = random1.Next(1, 50);
            int num2 = random1.Next(31, 150); // er større end num3 fordi hypotinosen må være større end kateten
            int num3 = random1.Next(15, 30);
            int num4 = random1.Next(10, 50); //areal skal være større end længder
            int num5 = random1.Next(1, 5); // forskellige længder så vi er sikker på at det ikke bliver rektangel
            int num6 = random1.Next(6, 10);
            double mellemregning = num5 + num6;
            rightanswer = Math.Round(Math.PI * 2 * num1, 1);
            rightanswerplus1 = Math.Round(Math.Sqrt(Math.Pow(num2, 2) - Math.Pow(num3, 2)), 1);
            rightanswerplus2 = Math.Round(2 *(num4 /mellemregning), 1);
            label_TASK.Text = "Du har en cirkel med radius " + num1.ToString() + " hvad er omkredsen?";
            label_Task1.Text = "Du har en hypotinose på " + num2.ToString() + " og en katete på " + num3.ToString(); ;
            label_Task2.Text = "Find højden på et trapez med areal " + num4.ToString() + " og længder på " + num5.ToString() + " og " + num6.ToString(); ; 

        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            //Leaderboard fv = new Leaderboard();
            //fv.Show();
            f.Visible = true;
            this.Close();
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
                    button_answer.Visible = false; //så man ikke kan svare rigtigt på samme spørgsmål 3 gange så timeren stopper
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
                    button_Answer1.Visible = false;
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
                    button_Answer2.Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e) //timer der tager tid
        {
            sekunder++;
            label_Timer.Text = sekunder + " sekunder";
            if (spørgsmål == 3)
            {
                timer1.Stop();
                MessageBox.Show("Du har klaret alle spørgsmål på " + sekunder + " sekunder");

                try
                {
                    string[] tider = File.ReadAllLines(@"c:\temp\leaderboard.txt");
                    StreamWriter leaderboard = new StreamWriter(@"c:\temp\leaderboard.txt");
                    
                    for (int i = 0; i <= 19; i++)
                    {
                        int tid = int.Parse(tider[i]);
                        if (4 < i & i < 10)
                        {
                            
                            int midl;
                            if (sekunder < tid)
                            {
                                midl = sekunder;
                                sekunder = tid;
                                tid = midl;
                                tider[i] = tid.ToString();

                            }
                        }
                        tider[i] = tider[i].ToString();
                        leaderboard.WriteLine(tider[i]);
                    

                    }
                    leaderboard.Close();


                }

                catch
                {
                    StreamWriter leaderboard = new StreamWriter(@"c:\temp\leaderboard.txt");
                    leaderboard.WriteLine("1000\n 1000\n 1000\n 1000\n 1000\n " + sekunder + " \n1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n 1000\n "); //skriver 1000 fem gange så rekorden ikke kommer under fejl kategori
                    leaderboard.Close();
                }
                
                
            }
        }
    }
}
