using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x + 1 * z;
            z = x - 1 - y * 5;
            y /= x + 5 % z;
            z = x + 1 + y * 5;
            x = y - x + 1 * z;



            Console.WriteLine("{0} {1} {2}", x, y, z);

            Console.ReadKey();

        }
    }
}
