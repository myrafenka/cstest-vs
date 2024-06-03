using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу расчета объема – V и площади поверхности – S цилиндра.
        //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h
        //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 + 2πR2 = 2πR(R+h)
        {
            Console.WriteLine("Please input Radius of the cylinder to calculate the Volume and Surface area of it");
            const float pi = 3.14f;
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input Height of the cylinder to calculate the Volume and Surface area of it");
            double h = Convert.ToDouble(Console.ReadLine());
            double V = pi * (R * R) * h;
            Console.WriteLine("Volume of cylinder: " + V);
            double S = 2 * pi * R * (R + h);
            Console.WriteLine("Surface area: " + S);
            Console.ReadLine();
        }
    }
}
