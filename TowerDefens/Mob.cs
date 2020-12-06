using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TowerDefens
{
    class Mob : Button
    {
        public int xp = 100;
        public int speed;
        //public string text;

        public Mob(decimal val)
        {
            this.xp = xp * Convert.ToInt32(val);
            this.Text = xp.ToString();
        }
    }
}
