using System;

namespace HelloWord
{
    class Program
    {

        static void Main(string[] args)
        {
            //Generation();
           novaFunkce();

        }

        private static void novaFunkce()
        {
            bool dotazovatSe = true;
            int cisloUzivatele = 0;
            Console.WriteLine($"Zadejte číslo:");
            do
            {

                string vstup = Console.ReadLine();
                if (!int.TryParse(vstup, out cisloUzivatele))
                {
                    Console.WriteLine($"Hodnota {vstup} nelze převést na číslo. Zkuste znova:");
                    continue;
                }
                Console.WriteLine($"Zadáno: {cisloUzivatele}");
                if (cisloUzivatele%2==0)
                    dotazovatSe = false;
            } while (dotazovatSe);
        }

        private static string urciDenTydne(int poradiDne)
        {
            switch (poradiDne)
            {
                case 1:
                    return "Pondělí";
                case 2:
                    return "Úterý";
                case 3:
                    return "Středa";
                case 4:
                    return "Čtvrtek";
                case 5:
                    return "Pátek";
                case 6:
                   
                case 7:
                    return "Víkend";
                default:
                    return $"Pořadí s číslem {poradiDne} není pořadí dne v týdnu.";
            }
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
