using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Box : Button
{
    public int indexPlayer = 0;
    //public int IndexPlayer
    //{
    //    get { return indexPlayer; }
    //    set { indexPlayer = value; }
    //}
    public static int Win = 0;

    public static int number1 = 1; // Номер игрока
    public static string Xod = "X"; // Фигура игрока

    public Box(int pointX, int pointY)
    {
        this.Text = string.Empty;
        this.Width = 50;
        this.Height = 50;
        this.Location = new System.Drawing.Point(pointX, pointY);
        this.Click += Box_Click;
    }

    private void Box_Click(object sender, EventArgs e)
    {
        this.indexPlayer = number1;
        this.Text = Xod;
        Remove();
    }
    public void Remove()
    {
        this.Click -= Box_Click;
    }
    public static void Players()
    {
        if (number1 == 1)
        {
            number1 = 2;
            Xod = "O";
        }
        else
        {
            number1 = 1;
            Xod = "X";
        }
    }
}

