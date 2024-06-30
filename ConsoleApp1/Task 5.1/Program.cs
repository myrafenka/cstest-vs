using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
//Створіть чотири методи для виконання арифметичних операцій з наступними іменами: Add -
// додавання, Sub - віднімання, Mul - множення, Div - ділення. Кожен метод має
// приймати два цілочисельних аргументи і виводити на екран результат виконання арифметичної
// операції, відповідної імені методу. Метод поділу Div повинен виконувати перевірку спроби ділення на
// нуль.
// Потрібно надати користувачеві можливість вводити з клавіатури значення операндів і знак
// арифметичної операції — для виконання обчислень.

{
    internal class Program
    {
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Sub(int number1, int number2)
        {
            return (number1 - number2);
        }

        static int Mul(int number1, int number2)
        {
            return (number1 * number2);
        }

        static Double Div(int number1, int number2)
        {
            return Convert.ToDouble(number1) / Convert.ToDouble(number2);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть 1-е число.");
            string number1 = Console.ReadLine();
            int result1 = Int32.Parse(number1);

            Console.WriteLine("Введіть 2-е число.");
            string number2 = Console.ReadLine();
            int result2 = Int32.Parse(number2);

            Console.WriteLine("Введіть дію, яку хочете виконати з числами");
            string dija = Console.ReadLine();
            int whatwegonnado = Char.Parse(dija);

            if (whatwegonnado == '+')
            {
                int result = Add(result1, result2);
                Console.WriteLine($"Результат додавання = {result}");
            }
            else if (whatwegonnado == '-')
            {
                int result = Sub(result1, result2);
                Console.WriteLine($"Результат віднімання = {result}");
            }
            else if (whatwegonnado == '*')
            {
                int result = Mul(result1, result2);
                Console.WriteLine($"Результат множення = {result}");
            }
            else if (whatwegonnado == '/' && result2 !=0)
            {
                double result = Div(result1, result2); 
                Console.WriteLine($"Результат ділення = {result}");
            }
            else Console.WriteLine($"Майте Бога в серці, на 0 ділити не можна!");

            // Delay.
            Console.ReadKey();
        }
    }
}
