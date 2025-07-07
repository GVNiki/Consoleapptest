using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    internal static class Extension
    {
        public static void Add(this MultiReturn obj, int x, int y)
        {
            Console.WriteLine("This is Add ");
            int z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public static void Sub(this MultiReturn obj)
        {
            Console.WriteLine("This is Sub");
        }
    }
}
