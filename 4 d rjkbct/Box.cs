using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Box : Button
{
    public Label lb;
    public XodPlayer player;
    public int indexPlayer = 0;
    public static int Win = 0;
    public int i;
    public int j;

    public Box(int pointX, int pointY, XodPlayer player123, Label lb, int i, int j)
    {
        this.Text = string.Empty;
        this.i = i;
        this.j = j;
        this.Width = 50;
        this.Height = 50;
        this.player = player123;
        this.lb = lb;
        this.Location = new System.Drawing.Point(pointX, pointY);
        this.Click += Box_Click;
    }

    private void Box_Click(object sender, EventArgs e)
    {
        this.indexPlayer = player.number1;
        this.Text = player.Xod;
        if (Win == 0)
        {
            player.Players();
            lb.Text = $"Ходит {player.number1} игрок";
        }
        //Unlock(i, j);
        Remove();
    }
    public void Remove()
    {
        this.Click -= Box_Click;
    }
}

