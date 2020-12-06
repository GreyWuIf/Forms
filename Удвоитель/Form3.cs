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
    public partial class Form3 : Form
    {
        public int count = 6;
        public int Q = 0;
        public Form3()
        {
            InitializeComponent();
            lblText.Text = "Угадайте число от 1 до 100 включительно";
            Form2 q = new Form2();
            Q = int.Parse(q.Random(101));
            label1.Text = count.ToString();
        }

        void Count()
        {
            count--;
            label1.Text = count.ToString();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string UserAnswer = textBox1.Text;
            if (UserAnswer == string.Empty)
            {
                lblAnswer.Text = "Введите число";
                textBox1.Clear(); 
            }
            else
            {
                if (int.Parse(UserAnswer) > Q && count > 1)
                {
                    lblAnswer.Text = "Введеное число больше задуманного";
                    textBox1.Clear();
                    Count();
                }
                else if (int.Parse(UserAnswer) < Q && count > 1)
                {
                    lblAnswer.Text = "Введеное число меньше задуманного";
                    textBox1.Clear();
                    Count();
                }
                else if (int.Parse(UserAnswer) == Q && count > 1)
                {
                    lblAnswer.Text = "Правильно! Вы угадали";
                }

                else
                {
                    lblAnswer.Text = "У Вас кончились попытки. Попробуйте заново";
                    Count();
                    textBox1.Enabled = false;
                    btnEnter.Enabled = false;
                    textBox1.Clear();
                }
            }

            

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Form2 q = new Form2();
            Q = int.Parse(q.Random(101));
            textBox1.Clear();
            lblAnswer.Text = string.Empty;
            textBox1.Enabled = true;
            count = 6;
            label1.Text = count.ToString();
        }
    }
}
