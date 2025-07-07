using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    internal class refandout
    {
        public static void outexample(int x, out int z, out int y)
        {
            Console.WriteLine("The value of x before calling "+ x);
            x += 30;
            z = x + 10;
            y = z + 5;
            Console.WriteLine("The value of x after calling "+ x);
            Console.WriteLine("The value of z is " + z);
            Console.WriteLine("The value of y is " + y);

        }

        public static void callingout()
        {
            int x = 20;
            Console.WriteLine("The value of x before calling " + x);
            outexample(x,out int z,out int y);
            Console.WriteLine("The value of x after calling " + x);
            Console.WriteLine("-----------------------------------");

        }

        public static void refexample(ref int x)
        {
            Console.WriteLine("The value of x before calling " + x);
            x = x + 30;
            Console.WriteLine("The value of x after calling " + x);

        }

        public static void callingref()
        {
            int x = 15;
            Console.WriteLine("The value of x before calling " + x);
            refexample(ref x);
            Console.WriteLine("The value of x after calling " + x);

        }

        
    }
}
