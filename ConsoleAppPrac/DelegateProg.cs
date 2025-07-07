using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    public delegate void call1();
    public delegate int call2(int x, int y, out int z);
    internal class DelegateProg
    {
        public void Add()   
        {
            Console.WriteLine("Add");
        }
        public void Sub() 
        {
            Console.WriteLine("Sub");
        }

        public static int Mul(int x, int y, out int z)  
        {
            z = x * y;
            Console.WriteLine("mul is " + z );
            return z;
        }

        public static int Div(int x, int y) 
        {
            Console.WriteLine("Div");
            return 1;
        }

    }
    public class Refnumber
    {
        public void r1(ref int x)
        {
            Console.WriteLine("x value is " + x);
            x = x + 20;
            Console.WriteLine("y value is " + x);
        }

        public void r2()
        {
            int x = 10;
            Console.WriteLine("x value is " + x);
            r1(ref x);
            Console.WriteLine("y value is " + x);

        }
    }
    public delegate int Calculation(int x, int y);
    public class Anonymous
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
    }
}
