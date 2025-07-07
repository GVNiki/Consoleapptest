using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    partial class MultiReturn
    {
        public int M1()
        {
            return 1;
        }
        public (int, string) M2()
        {
            return (10, "hi");
        }
        public void M3(int x, int y, out int Add, out int sub )
        {
            Add = x + y;
            sub = x - y;
        }

        public void M4(int x, int y = 0)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M5(int x,  int[] y)
        {
            Console.WriteLine(x);

            foreach (int item in y)
            {
                Console.WriteLine(item);
            }
        }


    }

    partial class MultiReturn
    {
        public void m1()
        {
            Console.WriteLine("Partial");
        }

    }
    partial class h1 : MultiReturn
    {
        public void m2()
        {
            Console.WriteLine("Parent Class is MultiReturn .I am child class h1");
        }
    }
}
