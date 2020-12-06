using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void rew(Button sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 87: label1.Text = "w"; sender.Top -= 20;
                    break;
                case 65: label1.Text = "a"; sender.Left -= 20;
                    break;
                case 83: label1.Text = "s"; sender.Top += 20;
                    break;
                case 68: label1.Text = "d"; sender.Left += 20;
                    break;
                default:
                    break;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            rew(button1, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == false)
            {
                timer2.Start();
            }
            else timer2.Stop();
        }
 
        public Class1 Qwe;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Qwe = new Class1();
            Qwe.Move1();
            Controls.Add(Qwe);
        }
    }
}
