using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)

        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Проверьте, можно ли создать переменные со следующими именами:
        //uberflu?, _Identifier, \u006fIdentifier, &myVar, myVariab1le
        {
            var uberflu? = 5; //ні, із-за "?" вкінці
            var _Identifier = 1; //може починаться з підкреслювання технічно
            var \u006fIdentifier = 15; //не може починатись з неалфавітних символів 
            var & myVar = 42; // не може починатись з символу "&"
            var myVariab1le = 55; // може
        }
    }
}
