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
    public partial class Form_Procent : Form
    {
        Form f;
        public Form_Procent()
        {
            InitializeComponent();
        }
        public Form_Procent(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Procent_task fpt = new Form_Procent_task(f);
            fpt.Show();
            this.Close();
        }
    }
}
