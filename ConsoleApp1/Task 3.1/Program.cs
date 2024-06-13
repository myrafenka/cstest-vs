using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
    //Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            {
                int A, B;
                Console.WriteLine("Введіть перше число");
                A = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть друге число, що > за перше");
                B = int.Parse(Console.ReadLine());

                Console.WriteLine("Всі непарні числа проміжку:");

                while (A < B)
                {
                    if (A % 2 != 0)
                    {
                        Console.WriteLine(A);
                    }
                    A++;
                }
            }

            {
                int A1, B1;
                Console.WriteLine("Введіть перше число");
                A1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть друге число, що > за перше");
                B1 = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int x = A1; x <= B1; A1++)
                {
                    sum += A1;
                    Console.WriteLine("Сума всіх чисел в проміжку " + sum);
                }
                

                Console.ReadKey();
            }
        }
    }
}

