using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractise
{
    internal class FactorialProg
    {
        public void Factorial()
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter the number:");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);

        }
    }
}
