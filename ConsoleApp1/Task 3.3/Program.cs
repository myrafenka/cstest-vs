using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{//Имеется N клиентов, которым компания производитель должна доставить товар.
 //Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?
 //Используя Visual Studio, создайте проект по шаблону Console Application.
 //Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
 //Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть, будь ласка, кількість клієнтів:");
            int N = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            int i = 1;
            do
            {
                factorial *= i;
                i++;
            } while (i <= N);

            Console.WriteLine($"Кількість маршрутів: {factorial}");
            Console.ReadLine();
        }
    }
}
