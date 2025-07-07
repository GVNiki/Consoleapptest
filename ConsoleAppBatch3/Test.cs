using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3
{
    internal class Test
    {
        public void Test1()
        {

            byte s = 245;  // unsigned only +
            sbyte sb = 127; // signed integre  + -
            Console.WriteLine(s);
            Console.WriteLine(sb);

            short s1 = -32768;


            // floating 
            //float double decimnal
            float f = 34.35f;
            double d = 34.45;
            decimal dm = 35.46m;
            Console.WriteLine(f);


            char c = 'd';

            bool b = true;

            string str = "jhdgfjhgf287t643876jdgfj@#@$@%#$%#$%#^";
            Console.WriteLine(str);


            // var dynamic & object
            // can hold any value

            // compile type
            var v1 = 45; // scope is taken as integer
            v1 = 67;


            var v2 = "hi hello";
            var v3 = 34.45;

            Console.WriteLine(v1);


            // runtime
            dynamic d1 = 34;
            d1 = "tes";
            d1 = true;
            dynamic d2 = "test";
            dynamic d3 = 34.45;
            dynamic d4 = 45;
            dynamic res = d3 + d4;
            Console.WriteLine(d1);


            //runtime
            object o1 = 4545;

            object o4 = 56;



            object o2 = "test";
            object o3 = true;
            Console.WriteLine(o1);
        }
    }

}

