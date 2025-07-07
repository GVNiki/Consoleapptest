using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    internal class ExceptionalHandling
    {
        public void M1()
        {
        a:
            try
            {
                int x, y,z;
                Console.WriteLine("Enter the x value: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y value; ");
                y = int.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine("Divition of "+ x+" and "+y+" is "+z);


            }catch (FormatException ex)
            {
                Console.WriteLine("Enter only in integer format");
                goto a;

            }catch (DivideByZeroException el)
            {
                Console.WriteLine("Dont give zero as y value");
                goto a;
            }
        
        }
    }
}
