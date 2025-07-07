using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    internal class Prop
    {
        private int x;   
        public int x_ 
        {
            get { return x; }
            set
            {

                if (value < 0 || value > 40)
                {
                    throw new ArgumentException("Value is more then range");
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value < 0 || value > 40)
                {
                    throw new ArgumentException("Value is more then range");
                }
                else
                {
                    y = value;
                }
            }
        }

        public void Add()
        {
            int z = x + y;  
            Console.WriteLine("Addition is:" + z);
        }


    }
}
