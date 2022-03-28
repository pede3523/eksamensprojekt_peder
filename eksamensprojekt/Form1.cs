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

        private void button_Vec_Click(object sender, EventArgs e) //når man trykker på knappen åbner et nyt vindue 
        {
            Form_Vector fv = new Form_Vector(); //kalder nyt vindue frem 
            this.Visible = false;
            fv.Show(); //viser vindue 
            
            
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Geo_Click(object sender, EventArgs e)
        {
            Form_Geomatri fg = new Form_Geomatri();
            this.Visible = false;
            fg.Show();
        }

        private void button_Tri_Click(object sender, EventArgs e)
        {
            Form_Trigonometri ft = new Form_Trigonometri();
            this.Visible = false;
            ft.Show();
        }
    }
}
