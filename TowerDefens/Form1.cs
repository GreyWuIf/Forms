using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerDefens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mob Mob;
        private void button1_Click(object sender, EventArgs e)
        {
            Mob = new Mob(numericUpDown1.Value);
            Controls.Add(Mob);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Remove(Mob);
        }
    }
}
