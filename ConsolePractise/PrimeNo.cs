using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractise
{
    internal class PrimeNo
    {
        public void PrimeNumber() {
            int n, i = 2, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = (int)Math.Sqrt(n);
            //m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(n+" is not Prime Number.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(n+" is Prime Number.");

        }
    }
}
