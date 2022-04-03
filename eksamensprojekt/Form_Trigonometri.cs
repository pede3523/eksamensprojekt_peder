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
    public partial class Form_Trigonometri : Form
    {
        Form f;
        public Form_Trigonometri()
        {
            InitializeComponent();
        }
        public Form_Trigonometri(Form f)
        {
            InitializeComponent();
            this.f =  f;
        }
        private void button_continue_Click(object sender, EventArgs e)
        {
            Form_Trigonometri_Task ftt = new Form_Trigonometri_Task(f);
            ftt.Show();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
