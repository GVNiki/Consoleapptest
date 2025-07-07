using ClassLibrary1;
using ClassLibrary2;
using ConsolePractiseProg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    internal class Testing
    {
        private static async Task Main(string[] args)
        {
            //Program.sub();
            //Program program = new Program("ok");
            //program.add();
            //Program p = Program.CreateObject();

            //MultiReturn multiReturn = new MultiReturn();
            //multiReturn.M1();
            //multiReturn.M3(12, 45, out int Add, out int sub);
            //multiReturn.M4(29);
            //multiReturn.M5(2,[89,90,78]);
            //multiReturn.Add(10,12);
            //multiReturn.Sub();

            //h1 h = new h1();
            //h.m2();
            //h.m1();

            //ExceptionalHandling exceptionalHandling = new ExceptionalHandling();
            //exceptionalHandling.M1();

            //Class1 class1 = new Class1();
            //class1.m1();

            //Checking checking = new Checking();
            //checking.m4();

            //DelegateProg d = new DelegateProg();
            //call1 c1 = new call1(d.Add);
            //c1 += new call1(d.Sub);
            //c1.Invoke();
            //call2 c2 = new call2(DelegateProg.Mul);
            //c2.Invoke(12,8,out int z);

            //Refnumber refnumber = new Refnumber();
            //refnumber.r2();

            //Prop prop = new Prop();
            //prop.x_= 10;
            //prop.y_= 20;
            //Console.WriteLine(prop.x_);
            //Console.WriteLine(prop.y_);
            //prop.Add();

            //Calculation c = new Calculation(Anonymous.Addition);
            //var cal = c.Invoke(10, 15);
            //Console.WriteLine(cal);

            //Calculation c1 = delegate (int x, int y) 
            //{
            //    return x + y;
            //};
            //int res1 = c1.Invoke(12, 4);
            //Console.WriteLine(res1);

            //Calculation c2 = (x, y) =>
            //{
            //    return x + y;
            //};
            //int res2 = c2.Invoke(12, 4);
            //Console.WriteLine(res2);

            //SynAndAsyn.met1();
            //SynAndAsyn.met2();

            //SynAndAsyn synAndAsyn = new SynAndAsyn();
            ////synAndAsyn.met3();
            //await synAndAsyn.met4();

            //LINQ.prac2();

            refandout.callingout();
            refandout.callingref();
        }
    }
}
