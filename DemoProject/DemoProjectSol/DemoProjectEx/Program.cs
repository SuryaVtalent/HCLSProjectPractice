using DemoProjectEx.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            ArithmeticOpt obj = new ArithmeticOpt();
            res=obj.Add(10,20);
            Console.WriteLine("The sum is "+res);
            res = obj.Sub(20, 10);
            Console.WriteLine("The Sub is " + res); 
            res = obj.Mul(10,20);
            Console.WriteLine("Th Mul is " + res);
            res = obj.Div(10, 20);
            Console.WriteLine("Th Div is " + res);
            res = obj.Rem(10, 20);
            Console.WriteLine("Th Rem is " + res);
            res = obj.Sum(10, 20);
            Console.WriteLine("Th Rem is " + res);
            Console.ReadKey();
        }
    }
}
