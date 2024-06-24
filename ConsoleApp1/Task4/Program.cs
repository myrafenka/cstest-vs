using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
        //Используя формулу πR2, вычислите площадь круга и выведите результат на экран.
        {
            Console.WriteLine("Please input Radius of the cyrcle to calculate the Area of it");
            const float pi = 3.14f;
            double r = Convert.ToDouble(Console.ReadLine());
            double Area = 2 * pi * (r * r);
            Console.WriteLine("Area: " + Area);
            Console.ReadLine();
        }
    }
}
