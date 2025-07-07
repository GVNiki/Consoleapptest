namespace ConsolePractise
{
    internal class Fibonacci
    {
        public void FibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(n1 + " ");
            Console.WriteLine(n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}

