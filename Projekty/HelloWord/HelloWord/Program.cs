using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! - Ahoj, tady Václav.");
            AddAndPrint(5, 10000);
        }
        static int AddAndPrint(int a , int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            return a + b;
        }
    }
}
