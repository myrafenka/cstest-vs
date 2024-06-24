using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
        //С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного отображения результата?
        {
            double x = 11, y = 25, z = 4;
            double result = (x + y + z) / 3;

            Console.WriteLine("Result: " + result);

            Console.ReadKey();
            // потрібно використовувати float або double тип, щоб коректно відобразились числа після коми
        }
    }
}
