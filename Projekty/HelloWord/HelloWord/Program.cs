using System;

namespace HelloWord
{
    class Program
    {

        static void Main(string[] args)
        {
            Generation();


        }
        public static void Generation()
        {
            Console.WriteLine($"Vložte rok narození:");
            int rok = 0;
            bool dotazovatSe = true;
            do
            {
                string vstup = Console.ReadLine();
                if (!int.TryParse(vstup, out rok))
                {
                    Console.WriteLine($"Hodnota {vstup} nelze převést na rok. Zkuste znova:");
                    continue;
                }
                dotazovatSe = false;
            } while (dotazovatSe);

      
            if(rok<1946)
            {
                Console.WriteLine($"{rok} Nelze určit");
                return;
            }
            if(rok>=1946 && rok<=1964)
                Console.WriteLine($"{rok} je generace Baby Boomerss");
            if (rok >= 1965 && rok <= 1980)
                Console.WriteLine($"{rok} je generace Generation X");
            if (rok >= 1981 && rok <= 1996)
                Console.WriteLine($"{rok} je generace Millenials");
            if (rok >= 1997 && rok <= 2012)
                Console.WriteLine($"{rok} je generace Generation Z");
            if (rok >= 2013)
                Console.WriteLine($"{rok} je generace Generation Alpha");


        }








    }
}
