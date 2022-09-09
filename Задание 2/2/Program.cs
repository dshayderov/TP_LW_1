using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_One
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 0.25;
            int z = 52;
            double f1 = 9.5;
            int U = 12;

            double g11 = t * z + z * f1 - (f1 + U) / t;

            Console.WriteLine("t = {0}", t);
            Console.WriteLine("z = {0}", z);
            Console.WriteLine("f1 = {0}", f1);
            Console.WriteLine("U = {0}", U);
            Console.WriteLine("g11 = {0} * {1} + {1} * {2} - ({2} + {3})/{0} = {4}", t, z, f1, U, g11);

            Console.ReadKey();
        }
    }
}
