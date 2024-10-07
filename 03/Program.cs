using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        delegate double DelegateAvarage(DelegateNumber[] dn);


        delegate int DelegateNumber();

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //int Func()  { int n = rnd.Next(100);  Console.WriteLine(n); return n; }
            //int Func() => rnd.Next(100);
            

            DelegateAvarage Avarage = (DelegateNumber[] dn) => dn.Average((d) => d.Invoke());
            ///DelegateAvarage Avarage2 = delegate(DelegateNumber[] dn) { return dn.Average((d) => d.Invoke()); };


            Console.WriteLine(Avarage(new DelegateNumber[] { () => rnd.Next(100), () => rnd.Next(100), () => rnd.Next(100), () => rnd.Next(100) }));


            ///Console.WriteLine(Avarage(new DelegateNumber[] { () => 10, () => 20, () => 30 }));



            Console.ReadKey();
        }
    }
}
