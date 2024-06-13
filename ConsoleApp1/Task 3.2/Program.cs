using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Используя циклы и метод: Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).
    //Выведите на экран: • прямоугольник • прямоугольный треугольник • равносторонний треугольник • ромб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть, будь ласка, довжину сторони квадрата:");
            int side = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (i == 0 || i == side - 1 || j == 0 || j == side - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

            Console.ReadKey();

            Console.WriteLine("Введіть, будь ласка, висоту прямокутного трикутника:");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();

            Console.WriteLine("Будь ласка, введіть висоту рівностороннього трикутника: ");
            int height1 = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < height1; i++)
            {
                for (int j = 0; j < height1 - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadKey();

            Console.WriteLine("Введіть, будь ласка, висоту ромба:");
            int height2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            for (int i = height - 2; i >= 0; i--)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
