using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Point Bod0001 = new Point(1, 2);
            Console.WriteLine($"Obsah = {Bod0001.Obsah()}");
            List<Person> people = new List<Person>();
            var p1 = new Person("Adam", "Smith", 1);
            var p2 = new Person("Jane", "Doe", 1);
            var p3 = new Person("Jan", "Novák", 1);
            var p4 = new Person("Marie", "Dolejší", 1);
            people.Add(p1);

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            //// ulozeni tuplu to Tuple typu
            //var tupleResult = MyTryParse("150.0");
            //succ = tupleResult.Item1;
            //val = tupleResult.Item2;

            //// ulozeni tuplu to Tuple typu - pojmenovane itemy
            //tupleResult = MyTryParse("150.0");
            //succ = tupleResult.success;
            //val = tupleResult.value;

            //// rozlozeni tuplu primo do promennych
            //(succ, val) = MyTryParse("150.0");




        }
        private static int ZiskejOdUzivateleCislo()
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
                dotazovatSe = false;
            }
            while (dotazovatSe);
            return cisloUzivatele;
        }
        private static string ZiskejOdUzivateleText()
        {
            bool dotazovatSe = true;
            string textUzivatele = "";
            Console.WriteLine($"Zadejte číslo:");
            do
            {

                textUzivatele = Console.ReadLine();
                if (textUzivatele==null || textUzivatele.Length<1)
                {
                    Console.WriteLine($"Nic rozumného nezadáno. Zkuste znova:");
                    continue;
                }
                dotazovatSe = false;
            }
            while (dotazovatSe);
            return textUzivatele;
        }


        private static void Soucet(int cislo)
        {
           
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
