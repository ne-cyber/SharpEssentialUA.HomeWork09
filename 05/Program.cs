using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        delegate double AvarageDelegate(int a, int b, int c);
        static void Main(string[] args)
        {
            AvarageDelegate Avarage = (a, b, c) => (a + b + c) / 3d;

            Console.WriteLine("Середнє арифметичне {0}, {1}, {2}: {3}", 2, 2, 3, Avarage.Invoke(2, 2, 3));

            Console.ReadKey();
        }
    }
}
