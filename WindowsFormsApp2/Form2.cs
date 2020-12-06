using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        int[][] reg = new int[8][];
        //public void PrintMatr()
        //{
        //    foreach (var item in reg)
        //    {
        //        for (int i = 0; i < item.Length; i++)
        //        {
        //            Console.Write($"{item[i]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        public int player = 1;
        public int b = 0;
        public string symbol = string.Empty;
        #region Методы проверки по вертикали
        /// <summary>
        /// Проверка по вертикали столбцов 1 и 8
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void Proverka1and8(int n, int m)
        {
            //int n = 2;
            //int m = 0;
            if (reg[n][m] == player && reg[n + 1][m] == player && reg[n + 2][m] == player && reg[n + 3][m] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
        }
        /// <summary>
        /// Проверка по вертикали столбцов 2 и 7
        /// </summary>
        /// <param name="j"></param>
        public void Proverka2and7(int j)
        {
            for (int i = 6; i >= 4; i--)
            {
                //int j = 0;
                int a = 0;
                int c = 0;
                if (reg[i][j + a] == player && reg[i - 1][j + 1] == player && reg[i - 2][j + 1] == player && reg[i - 3][j + 1 + a - c] == player)
                {
                    b = 1;
                    label1.Text = ($"Победил {player} игрок");
                }
                a = 1;
                c += 1;
            }  
        }
        /// <summary>
        /// Проверка по вертикали столбцов с 3 по 6
        /// </summary>
        /// <param name="j"></param>
        public void Proverka36(int j)
        {
           if (reg[7][j] == player && reg[6][j + 1] == player && reg[5][j + 2] == player && reg[4][j + 2] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[6][j + 1] == player && reg[5][j + 2] == player && reg[4][j + 2] == player && reg[3][j + 2] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[5][j + 2] == player && reg[4][j + 2] == player && reg[3][j + 2] == player && reg[2][j + 2] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[4][j + 2] == player && reg[3][j + 2] == player && reg[2][j + 2] == player && reg[1][j + 1] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[3][j + 2] == player && reg[2][j + 2] == player && reg[1][j + 1] == player && reg[0][j + 0] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            } 
        }
        #endregion
        #region Методы проверки по диагонали
        /// <summary>
        /// Проверка с 5ой позиции
        /// </summary>
        public void Proverka5(int i, int j)
        {
            // Диагональ с 5ой позиции
            if (reg[i][j] == player && reg[i - 1][j + 2] == player && reg[i - 2][j + 4] == player && reg[i - 3][j + 5] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            // Диагональ с 4ой позиции
            if (reg[i][j - 1] == player && reg[i - 1][j + 1] == player && reg[i - 2][j + 3] == player && reg[i - 3][j + 4] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[i - 1][j + 1] == player && reg[i - 2][j + 3] == player && reg[i - 3][j + 4] == player && reg[i - 4][j + 5] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            // Диагональ с 3ой позиции
            if (reg[i][j - 2] == player && reg[i - 1][j] == player && reg[i - 2][j + 2] == player && reg[i - 3][j + 3] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[i - 1][j] == player && reg[i - 2][j + 2] == player && reg[i - 3][j + 3] == player && reg[i - 4][j + 4] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
            if (reg[i - 2][j + 2] == player && reg[i - 3][j + 3] == player && reg[i - 4][j + 4] == player && reg[i - 5][j + 5] == player)
            {
                b = 1;
                label1.Text = ($"Победил {player} игрок");
            }
        }
        #endregion

        public void Proverka()
        {
            int q = 4; //Победная комбинация
            #region Проверка по горизонтали
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i].Length == 4)
                {
                    for (int j = 0; j <= 4 - q; j++)
                    {
                        if (reg[i][j] == player && reg[i][j + 1] == player && reg[i][j + 2] == player && reg[i][j + 3] == player)
                        {
                            b = 1;
                            label1.Text = ($"Победил {player} игрок");
                        }
                    }
                }
                if (reg[i].Length == 6)
                {
                    for (int j = 0; j <= 6 - q; j++)
                    {
                        if (reg[i][j] == player && reg[i][j + 1] == player && reg[i][j + 2] == player && reg[i][j + 3] == player)
                        {
                            b = 1;
                            label1.Text = ($"Победил {player} игрок");
                        }
                    }
                }
                if (reg[i].Length == 8)
                {
                    for (int j = 0; j <= 8 - q; j++)
                    {
                        if (reg[i][j] == player && reg[i][j + 1] == player && reg[i][j + 2] == player && reg[i][j + 3] == player)
                        {
                            b = 1;
                            label1.Text = ($"Победил {player} игрок");
                        }
                    }
                }
            }
            #endregion
            #region Проверка по вертикали
            Proverka1and8(2, 0);
            Proverka1and8(2, 7);

            Proverka2and7(0);
            Proverka2and7(5);

            Proverka36(0);
            Proverka36(1);
            Proverka36(2);
            Proverka36(3);
            #endregion
            #region Проверка по диагонали
            Proverka5(7, 2);


            #endregion
        }

        /// <summary>
        /// Цифровое значение в матрицу
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public string CheckMatrix(int n, int m)
        {
            if (reg[n][m] == 0 && b == 0)
            {
                if (player == 1)
                {
                    reg[n][m] = 1;
                    Check();
                    Proverka();
                    Players();
                    PrintPlayer();
                    return symbol;
                }
                else
                {
                    reg[n][m] = 2;
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

        public void UnLock(Button button)
        {
            button.Enabled = true;
        }

        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                if (i == 0 | i == 7) reg[i] = new int[4];
                else if (i == 1 | i == 6) reg[i] = new int[6];
                else reg[i] = new int[8];
            }
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
            button4.Text = CheckMatrix(0, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = CheckMatrix(1, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = CheckMatrix(1, 1);
            UnLock(button1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = CheckMatrix(1, 2);
            UnLock(button2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = CheckMatrix(1, 3);
            UnLock(button3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = CheckMatrix(1, 4);
            UnLock(button4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = CheckMatrix(1, 5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = CheckMatrix(2, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = CheckMatrix(2, 1);
            UnLock(button5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = CheckMatrix(2, 2);
            UnLock(button6);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = CheckMatrix(2, 3);
            UnLock(button7);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = CheckMatrix(2, 4);
            UnLock(button8);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = CheckMatrix(2, 5);
            UnLock(button9);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = CheckMatrix(2, 6);
            UnLock(button10);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Text = CheckMatrix(2, 7);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Text = CheckMatrix(3, 0);
            UnLock(button11);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Text = CheckMatrix(3, 1);
            UnLock(button12);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = CheckMatrix(3, 2);
            UnLock(button13);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Text = CheckMatrix(3, 3);
            UnLock(button14);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Text = CheckMatrix(3, 4);
            UnLock(button15);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Text = CheckMatrix(3, 5);
            UnLock(button16);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Text = CheckMatrix(3, 6);
            UnLock(button17);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Text = CheckMatrix(3, 7);
            UnLock(button18);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Text = CheckMatrix(4, 0);
            UnLock(button19);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Text = CheckMatrix(4, 1);
            UnLock(button20);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Text = CheckMatrix(4, 2);
            UnLock(button21);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Text = CheckMatrix(4, 3);
            UnLock(button22);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Text = CheckMatrix(4, 4);
            UnLock(button23);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Text = CheckMatrix(4, 5);
            UnLock(button24);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Text = CheckMatrix(4, 6);
            UnLock(button25);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Text = CheckMatrix(4, 7);
            UnLock(button26);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Text = CheckMatrix(5, 0);
            UnLock(button27);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Text = CheckMatrix(5, 1);
            UnLock(button28);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Text = CheckMatrix(5, 2);
            UnLock(button29);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Text = CheckMatrix(5, 3);
            UnLock(button30);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Text = CheckMatrix(5, 4);
            UnLock(button31);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.Text = CheckMatrix(5, 5);
            UnLock(button32);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Text = CheckMatrix(5, 6);
            UnLock(button33);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Text = CheckMatrix(5, 7);
            UnLock(button34);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Text = CheckMatrix(6, 0);
            UnLock(button36);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Text = CheckMatrix(6, 1);
            UnLock(button37);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.Text = CheckMatrix(6, 2);
            UnLock(button38);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.Text = CheckMatrix(6, 3);
            UnLock(button39);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Text = CheckMatrix(6, 4);
            UnLock(button40);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.Text = CheckMatrix(6, 5);
            UnLock(button41);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.Text = CheckMatrix(7, 0);
            UnLock(button44);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.Text = CheckMatrix(7, 1);
            UnLock(button45);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Text = CheckMatrix(7, 2);
            UnLock(button46);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Text = CheckMatrix(7, 3);
            UnLock(button47);
        }
    }
}
