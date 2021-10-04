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
            decimal k = 5;
            var kkde = 5M;

            //Console.WriteLine($"a = {a}, b = {b}");
            Vetsi(1, 2);
        }

        static void Vetsi(int a, int b)
        {
            Console.WriteLine($"Přijato a = {a}, b = {b}");
            if (a > b)
                Console.WriteLine($"Větší číslo je a. a = {a}.");
            if (a < b)
                Console.WriteLine($"Větší číslo je b. b = {b}.");
            if(a==b)
                Console.WriteLine($"Obě čísla mají stejnou velikost. a = b = {a}.");
        }


    }
}
