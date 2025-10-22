using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1 {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию (+, -, *, /):");
            char chr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Calculate(a, b, chr);
            Console.WriteLine();
            Console.WriteLine("Анализ первого числа:");
            Analysis(a);
            Console.WriteLine("Анализ второго числа:");
            Analysis(b);



        }
        public static void Calculate(double a, double b, char chr)
        {

            switch (chr)
            {
                case '+':
                    Console.WriteLine($"Резултат {a + b}"); break;
                case '-':
                    Console.WriteLine($"Резултат {a - b}"); break;
                case '*':
                    Console.WriteLine($"Резултат {a * b}"); break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Делить на но 0 нельзя");
                    }
                    else
                    {
                        Console.WriteLine($"Резултат {a / b}");
                    }
                    break;
                default:
                    Console.WriteLine("Операция не найдена");
                    break;
                            
                    
            }
            
        }
        
        public static void Analysis(double num)
        {
            if (num == 0)
            {
                Console.WriteLine("Ноль");
                return;
            }

            string parity = (num % 2 == 0) ? "четное" : "нечетное";
            string numbertype = (num > 0) ? "положительное" : "отрицательное";

            Console.WriteLine($"{num} - {parity}, {numbertype} число");
        }


    }

        
}
