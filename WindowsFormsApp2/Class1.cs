using System;
using System.Windows.Forms;

public class Class1 : Button
{
    public int Xp = 1000;
    public int Speed = 2;
    public Timer timer = new Timer()
    {
        Interval = 100     
    };
    public void timer2_Tick(object sender, EventArgs e)
    {
        this.Left += Speed;
    }
    public void Move1()
    {
        timer.Start();
        timer.Tick += timer2_Tick;
    }

    public Class1()
    {
        this.Text = $"{Xp}";
        this.Width = 50;
        this.Height = 50;
        this.Location = new System.Drawing.Point(0, 0);
    }

}
