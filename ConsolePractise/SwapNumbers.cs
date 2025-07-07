using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractise
{
    internal class SwapNumbers
    {
        public void Swaping()
        {
            int a = 55, b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;       
            b = a / b;       
            a = a / b;     
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
