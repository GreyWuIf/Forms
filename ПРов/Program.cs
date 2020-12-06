using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРов
{
    public class Info
    {
        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public Info(string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
        }
    }
    public class Box
    {
        public static int weight;
        public static int height;
        public int number;
        public Box(int weight, int height, int number)
        {
            Box.weight = weight;
            Box.height = height;
            this.number = number;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            Box[] box = new Box[5];
            for (int i = 0; i < box.Length; i++)
            {
                box[i] = new Box(50, 50, (i + 1));
            }
            for (int i = 0; i < box.Length; i++)
            {
                Console.WriteLine($"{box[i].number}, {Box.height}, {Box.weight}");
            }
            //Console.WriteLine($"{box[0].number}, {Box.height}, {Box.weight}");

            Box.height = 100;
            Box.weight = 100;

            for (int i = 0; i < box.Length; i++)
            {
                Console.WriteLine($"{box[i].number}, {Box.height}, {Box.weight}");
            }

            Console.ReadKey();

            var q = new Info(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine($"{q.Name} {q.FirstName}");
            Console.ReadKey();
        }

    }
}
