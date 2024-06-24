using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10, y = 12, z = 3;
            
                // 1) x += y - x++ * z;
                x = x++;
                double result1 = x += y - (x * z);
                Console.WriteLine("Result one: " + result1);
            
             
                //2) z = --x - y * 5;
                x = --x;
                double result2 = x - (y * 5);
                Console.WriteLine("Result two: " + result2);
            
                //3) y /= x + 5 % z;
                double result3 = y /= x + 5 % z;
                Console.WriteLine("Result three: " + result3);
            
               //4) z = x++ + y * 5;
                x = x++;
                double result4 = x + (y * 5);
                Console.WriteLine("Result four: " + result4);
            
                //5) x = y - x++ * z;
                x = x++;
                Double result5 = y - (x * z);
                Console.WriteLine("Result five: " + result5);
            
                Console.ReadKey();
            }
        }
    }
