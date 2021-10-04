using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! - Ahoj, tady Václav.");
            //AddAndPrint(5, 10000);
            //Pozdrav("Karle");
            int a = 20;
            int b = 30;

            int pom = a;
            a = b;
            b = pom;

            Console.WriteLine($"a = {a}, b = {b}");
        }

        static void Pozdrav( string jmeno)
        {
            Console.WriteLine($"Ahoj {jmeno}.");
            var x = 480 + 300.5 - 10f;
            var g = "gg" + 300;
            //unsi int kk = 1;
        }

        static int AddAndPrint(int a , int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            return a + b;

        }
    }
}
