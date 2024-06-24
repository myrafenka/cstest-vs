using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello");
            Console.WriteLine("Введіть числове значення");
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            Console.WriteLine(x + x);
            Console.WriteLine("Введіть числове значення");
            string input2 = Console.ReadLine();
            int y = Convert.ToInt32(input2);
            Console.WriteLine(x + y);


            ////byte test = 10;
            ////int myVal = 100000;
            ////double myVal2 = 10.5;
            ////bool flag = false;
            ////string name = "Anya";

            ////Console.WriteLine(test);
            ////Console.WriteLine(myVal);
            ////Console.WriteLine(myVal2);
            ////Console.WriteLine(flag);
            ////Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
