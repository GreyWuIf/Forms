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
    public partial class Form1 : Form
    {
        //public delegate void Del();
        //public delegate int Del(int n, int m);
        //public int a = 0;
        public int[,] matrix = new int[3, 3];
        public int player = 1;
        public int b = 0;
        public string symbol = string.Empty;

        /// <summary>
        /// Проверка на выигрышь
        /// </summary>
        public void Proverka()
        {
            for (int m = 0; m < 3; m++)
            {
                if (matrix[m, 0] == player && matrix[m, 1] == player && matrix[m, 2] == player && b == 0)
                {
                    b = 1;
                    label1.Text = ($"Победил {player} игрок");
                }
            }
            for (int m = 0; m < 3; m++)
            {
                if (matrix[0, m] == player && matrix[1, m] == player && matrix[2, m] == player && b == 0)
                {
                    b = 1;
                    label1.Text = ($"Победил {player} игрок");
                }
            }
            if (matrix[0, 0] == player && matrix[1, 1] == player && matrix[2, 2] == player && b == 0)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (matrix[0, 2] == player && matrix[1, 1] == player && matrix[2, 0] == player && b == 0)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }

        }
        /// <summary>
        /// Цифровое значение в матрицу
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public string CheckMatrix(int n, int m)
        {
            if (matrix[n, m] == 0 && b == 0)
            {
                if (player == 1)
                {
                    matrix[n, m] = 1;
                    Check();
                    Proverka();
                    Players();
                    PrintPlayer();
                    return symbol;
                }
                else
                {
                    matrix[n, m] = 2;
                    Check();
                    Proverka();
                    Players();
                    PrintPlayer();
                    return symbol;
                }
            }
            else if (b == 1) return symbol = string.Empty;
            return symbol;
        }
        /// <summary>
        /// Крестик или нолик
        /// </summary>
        /// <returns></returns>
        public void Check()
        {
            if (player == 1)
            {
                symbol = "X";
            }
            else symbol = "O";
        }

        /// <summary>
        /// Определяет ход игрока
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public void Players()
        {
            if (player == 1)
            {
                player = 2;
            }
            else player = 1;
        }
        /// <summary>
        /// Выводит на экран ход игрока
        /// </summary>
        public void PrintPlayer()
        {
            if (b == 0)
            {
                label1.Text = ($"Ходит {player} игрок");
            }
        }

        public Form1()
        {
            InitializeComponent();
            PrintPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = CheckMatrix(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = CheckMatrix(0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = CheckMatrix(0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = CheckMatrix(1, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = CheckMatrix(1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = CheckMatrix(1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = CheckMatrix(2, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = CheckMatrix(2, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = CheckMatrix(2, 2);
        }

        private void NewGame_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
