using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
//Напишіть метод, який буде визначати:
//1) Чи є введене число позитивним або негативним.
//2) Чи є воно простим (використовуйте техніку перебору значень).
//(Просте число - це натуральне число, яке ділиться на 1 і саме на себе. Щоб визначити просте число, чи
//ні, слід знайти всі його цілі дільники. Якщо дільників більше 2 -х, значить воно не просте)
//3) Чи ділиться на 2, 5, 3, 6, 9 без залишку.

namespace Task_5._3
{
    internal class Program
    {
        static string PositiveOrNegative(int number) //1) Чи є введене число позитивним або негативним.
        {
            if (number > 0)
            {
                return "Число позитивне";
            }
            else if (number < 0);
            {
                return "Число негативне";
            }
        }

        static bool SimpleOrNot(int number) //2) Чи є воно простим
        {
            if (number <=1)
            {
                return false;
            }

            for (int divisor = 2; divisor <=Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static string DivisionWithoutRemainder2(int number) //3) Чи ділиться на 2, 5, 3, 6, 9 без залишку. || number % 5 == 0 || number % 3 == 0 || number % 6 == 0 || number % 9 == 0
        {
            if (number % 2 == 0)
            {
                return "ділиться без залишку на 2";
            }
            else
            {
                return " НЕ ділиться без залишку на 2";
            }
        }
        static string DivisionWithoutRemainder5(int number)
        {
            if (number % 5 == 0)
            {
                return "ділиться без залишку на 5";
            }
            else
            {
                return " НЕ ділиться без залишку на 5";
            }
        }
        static string DivisionWithoutRemainder3(int number) 
        {
            if (number % 3 == 0)
            {
                return "ділиться без залишку на 3";
            }
            else
            {
                return " НЕ ділиться без залишку на 3";
            }
        }
        static string DivisionWithoutRemainder6(int number)
        {
            if (number % 6 == 0)
            {
                return "ділиться без залишку на 6";
            }
            else
            {
                return " НЕ ділиться без залишку на 6";
            }
        }
        static string DivisionWithoutRemainder9(int number)
        {
            if (number % 9 == 0)
            {
                return "ділиться без залишку на 9";
            }
            else
            {
                return " НЕ ділиться без залишку на 9";
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть число");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            string result = PositiveOrNegative(number);
            Console.WriteLine(result);
            if (SimpleOrNot (number))
            {
                Console.WriteLine($"{number} є простим числом. ");
            }
            else
            {
                Console.WriteLine($"{number} не є простим числом. ");
            }
            string result2 = DivisionWithoutRemainder2(number);
            Console.WriteLine(result2);
            string result5 = DivisionWithoutRemainder5(number);
            Console.WriteLine(result5);
            string result3 = DivisionWithoutRemainder3(number);
            Console.WriteLine(result3);
            string result6 = DivisionWithoutRemainder6(number);
            Console.WriteLine(result6);
            string result9 = DivisionWithoutRemainder6(number);
            Console.WriteLine(result9);
            // Delay.
            Console.ReadKey();
        }        
    } }