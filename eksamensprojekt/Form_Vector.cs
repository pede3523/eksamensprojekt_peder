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
    public partial class Form_Vector : Form
    {
        Form f;
        public Form_Vector()
        {
            InitializeComponent();
         
        }
        public Form_Vector(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            Form_Vector_Task fvt = new Form_Vector_Task(f);
            this.Visible = false;
            fvt.Show();
            this.Close();
            //this.Close(); //kan lukke denne men ikke den første da det er hoved formen 
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
