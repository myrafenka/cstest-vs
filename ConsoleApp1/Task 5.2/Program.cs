using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
//Напишіть програму, яка буде виконувати конвертування валют.
//Користувач вводить:
//- суму грошей в певній валюті.
//- курс для конвертації в іншу валюту.
//Організуйте виведення результату операції конвертації валюти на екран.

namespace Task_5._2
{
    internal class Program
    {
        static void Convertation(ref double money, ref double course, ref double results)
        {
            results = money * course;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть суму грошей в певній валюті");
            string money1 = Console.ReadLine();
            double money2 = Convert.ToDouble(money1);

            Console.WriteLine("Введіть курс для конвертації в іншу валюту");
            string course1 = Console.ReadLine();
            double course2 = Convert.ToDouble(course1);

            double results = 0;
            Convertation(ref money2, ref course2, ref results);
            Console.WriteLine($"Результат операції конвертації валюти = {results}");

            // Delay.
            Console.ReadKey();
        }
    }
}
