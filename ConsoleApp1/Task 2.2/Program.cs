using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
//Если да, то укажите, в какой именно промежуток.
//Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть число від 0 до 100: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 14;
            int c = 15;
            int d = 35;
            int e = 36;
            int f = 50;
            int g = 51;
            int k = 100;

            if ((input >= a) && (input <= b))
            {
                Console.WriteLine("числовий проміжок - [0 - 14]");
            }
            else if ((input >= c) && (input <= d))
            {
                Console.WriteLine("числовий проміжок - [15 - 35]");
            }
            else if ((input >= e) && (input <= f))
            {
                Console.WriteLine("числовий проміжок - [36 - 50]");
            }
            else if ((input >= g) && (input <= k))
            {
                Console.WriteLine("числовий проміжок - [51 - 100]");
            }
            else
            {
                Console.WriteLine("число не входить в жоден числовий проміжок");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
