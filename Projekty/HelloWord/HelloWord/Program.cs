using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! - Ahoj, tady Václav.");
            //AddAndPrint(5, 10000);
            Pozdrav("Karel");
        }

        static void Pozdrav( string jmeno)
        {
            Console.WriteLine($"Ahoj { jmeno}.");
        }

        static int AddAndPrint(int a , int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            return a + b;

        }
    }
}
