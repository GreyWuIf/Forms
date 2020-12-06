using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_in_the_wheel
{
    public partial class Form1 : Form
    {
        public Box[,] but = new Box[8, 8];

        public XodPlayer player1 = new XodPlayer();

        public Label lb = new Label();

        public Form1()
        {
            InitializeComponent();
            lb.Text = $"Ходит {player1.number1} игрок";
            lb.Location = new Point(550, 40);
            int PointX = 10;
            int PointY = 10;
            #region Инициализация поля
            for (int i = 0; i < but.GetLength(0); i++)
            {
                for (int j = 0; j < but.GetLength(1); j++)
                {
                    but[i, j] = new Box(PointX, PointY, player1, lb, i, j);
                    Controls.Add(but[i, j]);
                    but[i, j].Enabled = false;
                    but[i, j].TextChanged += Form1_TextChanged;
                    if (j == 7)
                    {
                        PointX = 10;
                        PointY += but[i, j].Height + 5;                        
                    }
                    else PointX += but[i, j].Width + 5;
                    if ((i == 0 || i == 7) && ((j == 0 || j == 7) || (j == 1 || j == 6)))
                    {
                        but[i, j].Visible = false;
                    }
                    else if ((i == 1 || i == 6) && (j == 0 || j == 7)) but[i, j].Visible = false;
                    switch (i)
                    {
                        case 5:
                            if (j == 0 || j == 7)
                            {
                                but[i, j].Enabled = true;
                            }
                            break;
                        case 6:
                            if (j == 1 || j == 6)
                            {
                                but[i, j].Enabled = true;
                            }
                            break;
                        case 7:
                            but[i, j].Enabled = true;
                            break;
                        default:
                            break;
                    }

                }
            }
            #endregion
            Controls.Add(lb);
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            Check();
            Unlock();
        }
        /// <summary>
        /// Проверка на победителя
        /// </summary>
        public void Check()
        {
            #region Проверка по горизонтали
            for (int i = 0; i < but.GetLength(0); i++)
            {
                for (int j = 0; j < but.GetLength(1) - 3; j++)
                {
                    int w = 0;
                    List<Button> mas = new List<Button>();
                    for (int k = 0; k < 4; k++)
                    {
                        if (but[i, j + k].indexPlayer == player1.number1)
                        {
                            w++;
                            mas.Add(but[i, j + k]);
                            if (w == 4)
                            {
                                foreach (var item in mas)
                                {
                                    item.ForeColor = Color.Red;
                                }
                                Box.Win = 1;
                                lb.Text = $"Победил игрок {player1.number1}";
                                Del();
                            }
                        }
                    }
                }
            }
            #endregion
            #region Проверка по вертикали
            for (int i = 0; i < but.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < but.GetLength(1); j++)
                {
                    int w = 0;
                    List<Button> mas = new List<Button>();
                    for (int k = 0; k < 4; k++)
                    {
                        if (but[i + k, j].indexPlayer == player1.number1)
                        {
                            w++;
                            mas.Add(but[i + k, j]);
                            if (w == 4)
                            {
                                foreach (var item in mas)
                                {
                                    item.ForeColor = Color.Red;
                                }
                                Box.Win = 1;
                                lb.Text = $"Победил игрок {player1.number1}";
                                Del();
                            }
                        }
                    }
                }
            }
            #endregion
            #region Проверка по диагонали
            for (int i = 0; i < but.GetLength(0) - 3; i++)
            {
                for (int j = 3; j < but.GetLength(1); j++)
                {
                    int w = 0;
                    List<Button> mas = new List<Button>();
                    for (int k = 0; k < 4; k++)
                    {
                        if (but[i + k, j - k].indexPlayer == player1.number1)
                        {
                            w++;
                            mas.Add(but[i + k, j - k]);
                            if (w == 4)
                            {
                                foreach (var item in mas)
                                {
                                    item.ForeColor = Color.Red;
                                }
                                Box.Win = 1;
                                lb.Text = $"Победил игрок {player1.number1}";
                                Del();
                            }
                        }
                    }
                }
            }
            for (int i = 4; i >= but.GetLength(0) - 8; i--)
            {
                for (int j = 0; j < but.GetLength(1) - 3; j++)
                {
                    int w = 0;
                    List<Button> mas = new List<Button>();
                    for (int k = 0; k < 4; k++)
                    {
                        if (but[i + k, j + k].indexPlayer == player1.number1)
                        {
                            w++;
                            mas.Add(but[i + k, j + k]);
                            if (w == 4)
                            {
                                foreach (var item in mas)
                                {
                                    item.ForeColor = Color.Red;
                                }
                                Box.Win = 1;
                                lb.Text = $"Победил игрок {player1.number1}";
                                Del();
                            }
                        }
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Удаляет у кнопки действие
        /// </summary>
        public void Del()
        {
            for (int i = 0; i < but.GetLength(0); i++)
            {
                for (int j = 0; j < but.GetLength(1); j++)
                {
                    but[i, j].Remove();
                }
            }
        }
        /// <summary>
        /// Снимает блокировку кнопки выше
        /// </summary>
        public void Unlock()
        {
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < but.GetLength(1); j++)
                {
                    if (but[i, j].indexPlayer != 0 && i != 0)
                    {
                        but[i - 1, j].Enabled = true;
                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
