using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Удвоитель
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Udvoitel_Click(object sender, EventArgs e)
        {
            var b = new Form2();
            b.Show();
        }

        private void Ugadayka_Click(object sender, EventArgs e)
        {
            var b = new Form3();
            b.Show();
        }
    }
}
