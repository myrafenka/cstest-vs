using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу – консольный калькулятор. x
//Создайте две переменные с именами operand1 и operand2.
//Задайте переменным некоторые произвольные значения.
//Предложите пользователю ввести знак арифметической операции.
//Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
//Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
//Выведите на экран результат выполнения арифметической операции.
//В случае использования операции деления, организуйте проверку попытки деления на ноль.
//И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double operand1, operand2, calculation;
            char sign;

            Console.WriteLine("Будь ласка, введіть перше число");
            operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Будь ласка, введіть друге число");
            operand2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Будь ласка, введіть знак арифметичної операції (+, -, *, /) яку хочете виконати: ");
            sign = char.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+': calculation = operand1 + operand2;
                    Console.WriteLine("Результат: " + calculation);
                    break;
                case '-': calculation = operand1 - operand2;
                    Console.WriteLine("Результат: " + calculation);
                    break;
                case '*': calculation = operand1 * operand2;
                    Console.WriteLine("Результат: " + calculation);
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("На 0 ділити не можна!");
                    }
                    else
                    {
                        calculation = operand1 / operand2;
                        Console.WriteLine("Результат: " + calculation);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Ввід некоректний");
                        break;
                    }
            }
            // Delay.
            Console.ReadKey();

        }
    }
}
