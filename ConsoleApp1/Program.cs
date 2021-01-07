using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int[,] arr = new int[8, 8];
        public int this[int i, int j]
        {
            get { return arr[i, j]; }
            set { arr[i, j] = value; }
        }
        static void Main(string[] args)
        {
            //var q = new Program();
            //arr[0, 0] = 50;
            Console.WriteLine(arr[0, 0]);
            Console.ReadKey();
        }
    }
}
