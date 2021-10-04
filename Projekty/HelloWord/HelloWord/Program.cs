using System;

namespace HelloWord
{
    class Program
    {
        const int c_a = 155;
        const int c_b = 255;
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
            decimal k = 5;
            var kkde = 5M;

            //Console.WriteLine($"a = {a}, b = {b}");
            int vetsi = Vetsi(1, 2);
            Console.WriteLine($"Větší číslo = {vetsi}.");
        }


        static int Vetsi(int a, int b)
        {
            if (a == c_a || a == c_b)
            {
                if (a > b) return b;
                else return a;
            }
            if (a > b)
            {
                return a;
            }
            return b;
            
            
        }


    }
}
