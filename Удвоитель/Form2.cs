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
    public partial class Form2 : Form
    {
        //int Rnd = 0;
        public Form2()
        {
            InitializeComponent();
            //btnCommand1.Text = "+1";
            //btnCommand2.Text = "x2";
            //btnReset.Text = "Сброс";
            //lblNumber.Text = "0";
            this.Text = "Удвоитель";
            Random(1001);
            //Rnd = rnd;
        }

        public string Random(int a)
        {
            Random random = new Random();
            int rnd = random.Next(1, a);
            //Form2 q = new Form2();
            return RandomNumber.Text = rnd.ToString();
        }

        int count = 0;
        public void Count()
        {
            lblCount.Text = count.ToString();
        }

        void Check()
        {
            if (int.Parse(RandomNumber.Text) == int.Parse(lblNumber.Text))
            {
                labelUbv.Text = "Вы победили";
            }
            else if (int.Parse(lblNumber.Text) > int.Parse(RandomNumber.Text))
            {
                labelUbv.Text = "Вы проиграли";
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            count++;
            Count();
            Check();
        }
 
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            count++;
            Count();
            Check();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            count = 0;
            Count();
            labelUbv.Text = "Удвоитель";
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            Random(1001);
        }

    }
}
