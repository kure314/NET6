using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWord
{
    class Prevody
    {
        public static void PrevodNaCelsius()
        {
            Console.WriteLine($"Vložte hodnotu ve °F:");
            double farn = 0;
            bool dotazovatSe = true;
            do
            {
                string vstup = Console.ReadLine();
                if (!double.TryParse(vstup, out farn))
                {
                    Console.WriteLine($"Hodnota {vstup} nelze převést. Zkuste znova:");
                    continue;
                }
                dotazovatSe = false;
            } while (dotazovatSe);
            Console.WriteLine($"Výsledek: {farn} °F = {(farn - 32d) / 1.8d} °C");
        }
    }
}
