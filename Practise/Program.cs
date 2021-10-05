using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 10;
            int b = 20;
            Sum s = new Sum();
            Sub su = new Sub();
            Mul m = new Mul();
            Console.WriteLine(s.Add(a,b));
            Console.WriteLine(su.Substraction(a, b));
            Console.WriteLine(m.Multiply(a, b));
        }
    }
}
