using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char k;
            float a, b;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("+ - / *");
            k = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());

            switch(k)
                {
                case '+':
                Console.WriteLine(a + b);
                    break;

                case '-':
                    Console.WriteLine(a - b);
                    break;

                case '/':
                    if(b != 0)
                    {
                        Console.WriteLine(a / b);
                    }
                    else 
                    {
                        Console.WriteLine("Иди нахуй, долбаёб"); 
                    }
                    break;

                case '*':
                    Console.WriteLine(a * b);
                    break;

            }
      
            Console.ReadKey();
        }

    }
}



