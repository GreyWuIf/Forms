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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Button[,] but = new Button[8, 8];

            InitializeComponent();
            int PointX = 10;
            int PointY = 10;
            #region Инициализация поля
            for (int i = 0; i < but.GetLength(0); i++)
            {
                for (int j = 0; j < but.GetLength(1); j++)
                {
                    but[i, j] = new Button();
                    but[i, j].Size = new Size(50, 50);
                    but[i, j].Location = new Point(PointX, PointY);
                    but[i, j].Click += Form1_Click; ;
                    Controls.Add(but[i, j]);
                    if (j == 7)
                    {
                        PointX = 10;
                        PointY += but[i, j].Height + 5;                        
                    }
                    else PointX += but[i, j].Width + 5;
                }
            }
            #endregion
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //.Text = "X";
        }
    }
}
