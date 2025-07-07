namespace ConsolePractiseProg
{
    internal class Program
    {
        //    public Program()  
        //{
        //    Console.WriteLine("any logic");
        //}

        public Program(int x)  
        {
            Console.WriteLine("1 numbers");
        }
        public Program(string x)  
        {
            Console.WriteLine("st strings");
        }


        public void add()
        {  
            Console.WriteLine("non static Add");
        }

        public static void sub()
        { 
            Console.WriteLine("Static sub");
        }

        private Program()  
        {
            Console.WriteLine("Private constructor");
        }

        public static Program CreateObject()
        {
            return new Program(); 
        }

        

    }
}