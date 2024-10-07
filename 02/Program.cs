using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        delegate double MyDelegate(double a, double b);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            MyDelegate Add = (a, b) => a + b;
            MyDelegate Sub = (a, b) => a - b;
            MyDelegate Mul = (a, b) => a * b;
            MyDelegate Div = (a, b) => { if (b != 0) return a / b; else { Console.WriteLine("Div by zero!"); return 0; } };

            while(true)
            {
                Console.Write("Введіть число а: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введіть число b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введіть операцію: ");
                string oper = Console.ReadLine();

                switch(oper)
                {
                    case "+":
                        Console.WriteLine(Add.Invoke(a, b)); 
                        break;
                    case "-":
                        Console.WriteLine(Sub.Invoke(a, b));
                        break;
                    case "*":
                        Console.WriteLine(Mul.Invoke(a, b));
                        break;
                    case "/":
                        Console.WriteLine(Div.Invoke(a, b));
                        break;
                }


                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
