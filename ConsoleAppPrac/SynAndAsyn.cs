using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrac
{
    internal class SynAndAsyn
    {
        public async static Task met1()
        {
            Console.WriteLine("Start");

            await Working();  

            Console.WriteLine("End");
        }

        public async static Task Working()
        {
            await Task.Delay(3000);  
            Console.WriteLine("Work done");
        }

        public static void met2()
        {
            Console.WriteLine("Start");

            Working1();

            Console.WriteLine("End");
        }

        public static void Working1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work done");
        }

        public int GetValue(string Filename)
        {
            int length = 0;

            using (StreamReader sr = new StreamReader(Filename))
            {

                string str = sr.ReadToEnd();
                length = str.Length;
                Task.Delay(5000).Wait();
            }
            return length;
        }

        public void met3()
        {
            string filename = "C:\\Users\\nikitha.gv\\Documents\\Training\\DotNet\\Topics.txt";
            int res = GetValue(filename);
            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            Console.WriteLine("The lenth of file is :" + res);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");
        }

        public async Task<int> GetValue1(string Filename)
        {
            int length = 0;

            using (StreamReader sr = new StreamReader(Filename))
            {

                string str = await sr.ReadToEndAsync();
                length = str.Length;
                await Task.Delay(5000);
            }
            return length;
        }

        public async Task met4()
        {
            string filename = "C:\\Users\\nikitha.gv\\Documents\\Training\\DotNet\\Topics.txt";
            Task<int> res = GetValue1(filename);
            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            int lengths = await res;
            Console.WriteLine("The lenth of file is :" + lengths);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");
        }
            
    }

    public class LINQ
    {
        public static void prac()
        {
            
            int[] arr = { 34, 34, 5, 45, 6, 576, 7, 8, 98, 9, 9, 0, 9, 0, 23, 34, 45, 45, 6 };

            var res = from s in arr where s >= 50 select s;
            
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public static void prac2()
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,89,56
            };
            List<int> integerList3 = new List<int>()
            {
                1, 2, 3, 4, 5, 9, 10,89,56,678,900
            };
            List<object> integerList2 = new List<object>()
            {
                "hi","hello",90,8,7,"ok",9,10,11,12,13,"yes"
            };

            var res = from s in integerList where s > 5 select s;
            var res1 = integerList.Where(obj => obj > 5).ToList();
            var res2 = integerList2.OfType<string>().ToList();
            var res3 = (from s in integerList3 select s).Except(integerList).ToList();
            var res4 = (from s in integerList3 select s).Average();
            //Console.WriteLine(res4);
            var res5 = (from s in integerList3 select s).Contains(56);
            //Console.WriteLine(res5);
            var res6 = (from s in integerList3 select s).Any(s => s >= 10);
            Console.WriteLine(res6);
            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
