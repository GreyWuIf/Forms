using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class XodPlayer
{
    public int number1 = 1;
    public string Xod = "X";
    public void Players()
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

