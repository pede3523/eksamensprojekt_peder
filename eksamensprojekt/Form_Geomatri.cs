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
    public partial class Form_Geomatri : Form
    {
        Form f; 
        public Form_Geomatri()
        {
            InitializeComponent();
        }
        public Form_Geomatri(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Geomatri_task fgt = new Form_Geomatri_task(f);
            fgt.Show();
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
