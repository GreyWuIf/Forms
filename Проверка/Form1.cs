using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверка
{
    public class Buttonn : Button
    {
        public int chislo { get; set; }
    }
    public partial class Form1 : Form
    {
        Buttonn[,] but = new Buttonn[8, 8];
        //public Buttonn this[int i, int j]
        //{
        //    get { return but[i, j]; }
        //    set { but[i, j] = value; }
        //}
        Label lb = new Label();
        public Form1()
        {
            InitializeComponent();
            int w = 1;
            int PointX = 10;
            int PointY = 10;
            for (int i = 0; i < but.GetLength(0); i++)
            {
                for (int j = 0; j < but.GetLength(1); j++)
                {
                    but[i, j] = new Buttonn();
                    but[i, j].Location = new System.Drawing.Point(PointX, PointY);
                    but[i, j].Width = 40;
                    but[i, j].Height = 40;
                    but[i, j].Click += button_Click;
                    but[i, j].chislo = w;
                    //but[i, j].Text = $"{w}";
                    w++;
                    Controls.Add(but[i, j]);
                    if (j == 7)
                    {
                        PointX = 10;
                        PointY += but[i, j].Height + 5;
                    }
                    else PointX += but[i, j].Width + 5;
                }
            }
            lb.Location = new Point(500, 50);
            Controls.Add(lb);
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" --- ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
