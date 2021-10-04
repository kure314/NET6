using System;

namespace HelloWord
{
    class Program
    {

        static void Main(string[] args)
        {

            int a = 23;
            double d = 444.5698;

            //Console.WriteLine($"a = {a}, (int)d = {(int)d}");
            //Console.WriteLine($"a = {a}, Convert.ToInt32(d) = {Convert.ToInt32(d)}");
            //Convert.ToInt32(2);

            PrevodNaCelsius();

        }

        private static void PrevodNaCelsius()
        {
            Console.WriteLine($"Vložte hodnotu ve °F:");
            double farn = 0;
            bool dotazovatSe = true;
            while (dotazovatSe)
            {
                string vstup = Console.ReadLine();
                
                if(!double.TryParse(vstup, out farn))
                {
                    Console.WriteLine($"Hodnota {vstup} nelze převést. Zkuste znova:");
                    continue;
                }
                dotazovatSe = false;
            }

            Console.WriteLine($"Výsledek: {farn} °F = {(farn-32d)/1.8d} °C");


        }

   




    }
}
