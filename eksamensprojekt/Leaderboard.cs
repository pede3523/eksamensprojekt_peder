using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eksamensprojekt
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            string[] tider = File.ReadAllLines(@"c:\temp\leaderboard.txt");
            int i = 5;
            listBox_Vector.SelectedValue = tider[i];
        }

        private void button_finish_Click(object sender, EventArgs e)
        {

        }
    }
}
