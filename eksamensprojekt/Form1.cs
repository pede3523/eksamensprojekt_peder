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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Vec_Click(object sender, EventArgs e) //når man trykker på knappen åbner et nyt vindu 
        {
            Form_Vector fv = new Form_Vector(); //kalder nyt vindu frem 
            this.Visible = false;
            fv.Show(); //viser vindu 
            
            
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
