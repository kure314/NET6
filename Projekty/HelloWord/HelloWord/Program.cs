using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Dataset;
using Dataset.Model;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = Data.LoadFromXML();

            Console.WriteLine($"Počet načtených klientů: {clients.Count()}");

            var result0 = clients.Select(c => c.FirstName); // vrátí pole stringů s FirstName

            

            var result2 = clients.GroupBy(c => c.HomeAddress.City);

            // select
            //var result = clients
            //                .Where(c => c.Age() > 50)
            //                .Select(c => new { c.FirstName, c.LastName } );

            //select anonymous type
            //var result = clients.Select(client => client.FirstName);

            //group by
            var result = clients.GroupBy(client => client.HomeAddress.City);

            ////vypis vsech
            foreach (var item in result)
            {
                //Console.WriteLine($"město: {item.Key} - počet lidí: {item.Count()}");
            }


            Client nejstarsi = clients.OrderByDescending(c => c.Age()).First();
            //Console.WriteLine($"Nejstarší klient: {nejstarsi.FirstName} {nejstarsi.LastName}, věk: {nejstarsi.Age()}");

            //var nejstarsi_v2 = clients.OrderByDescending(c => c.Age()).Select(c => new {jmeno= c.celeJmeno, vek = c.Age() }).First();
            //Console.WriteLine($"Nejstarší klient: {nejstarsi_v2.jmeno}, věk: {nejstarsi_v2.vek}");
            //Client nejmladsi = clients.OrderBy(c => c.Age()).First();
            //Console.WriteLine($"Nejmladší klient: {nejmladsi.FirstName} {nejmladsi.LastName}, věk: {nejmladsi.Age()}");

         
            var dleMest = clients.GroupBy(x => x.HomeAddress.City);
            foreach (var item in dleMest)
            {
                var mesto = item.Key;
                Client nejbohatsi = item.OrderByDescending(c => c.AccountSum()).First();
                Console.WriteLine($"Město: {item.Key}, klient: {nejbohatsi.celeJmeno}, na účtu: {nejbohatsi.AccountSum()}");
            }




  



            //////vypis vsech
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}






        }
        static void Main2(string[] args)
        {
            System.Data.DataTable dataTable = VytvoritTabulku();

            foreach (System.Data.DataRow item in dataTable.Rows)
            {
                Console.WriteLine($"id: {item[0]}, jméno: {item[1]}");
            }

            //dataTable.Rows.fi


            int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            /// z "numebers" zjistěte:
            /// 1. počet prvků v poli
            Console.WriteLine($"1. počet prvků v poli {numbers.Count()}" );
            /// 2. největší hodnotu
            Console.WriteLine($"2. největší hodnotu: {numbers.Max()}");
            /// 3. nejmenší hodnotu
            Console.WriteLine($"3. nejmenší hodnotu: {numbers.Min()}");
            /// 4. průměr
            Console.WriteLine($"4. průměr: {numbers.Average()}");
            /// 5. kolik obsahuje pole kladných čísel
            Console.WriteLine($"6. kolik obsahuje pole záporných čísel: { numbers.Where(r=>r>=0).Count()  }");
            /// 6. kolik obsahuje pole záporných čísel
            Console.WriteLine($"6. kolik obsahuje pole záporných čísel { numbers.Where(r => r < 0).Count()  }");
            /// 7. sumu všech hodnot
            Console.WriteLine($"7. sumu všech hodnot {numbers.Sum()}");
            /// 8. sumu kladných hodnot
            Console.WriteLine($"8. sumu kladných hodnot {numbers.Where(r => r > 0).Sum()}");


            ////// projection / restrikce / filtrovani - Where

            /// 9. všechna čísla větší než -500
            /// 10. všechna kladná sudá čísla
            /// 11. čísla v rozstahu -400 až 400


            //foreach (var item in ordered)
            //{
            //    Console.WriteLine(item);
            //}







        }



        public static System.Data.DataTable VytvoritTabulku()
        {
            System.Data.DataTable tabulka = new System.Data.DataTable();
            tabulka.Columns.Add("_id", typeof(int));
            tabulka.Columns.Add("_jmeno", typeof(string));

            tabulka.Rows.Add(1, "Karel");
            tabulka.Rows.Add(2, "Marek");
            tabulka.Rows.Add(3, "Křemílek");
            tabulka.Rows.Add(4, "Vochomůrka");
            return tabulka;
        }




        static void MainXX(string[] args)
        {
            Person osoba = new Person("Karel", "Havran");
            osoba.HomeAdress.City = "Brno";

            Person p2 = new Person();
            p2.HomeAdress = osoba.HomeAdress;
            Console.WriteLine(osoba);
            Console.WriteLine(p2);



            /*
            Point Bod0001 = new Point(1, 2);
            Consohomele.WriteLine($"Obsah = {Bod0001.Obsah()}");
            List<Person> people = new List<Person>();
            var p1 = new Person("Adam", "Smith", 1);
            var p2 = new Person("Jane", "Doe", 1);
            var p3 = new Person("Jan", "Novák", 1);
            var p4 = new Person("Marie", "Dolejší", 1);
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);

            string fileName = "people.txt";
            foreach (Person item in people)
            {
                File.AppendAllText(fileName, item.VypisDoSouboru() + Environment.NewLine);
            }

            List<Person> Nacteno = LoadPeople(fileName);

            foreach (Person item in Nacteno)
            {
                Console.WriteLine(item);
            }
            */




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

        private static List<Person> LoadPeople(string fileName)
        {
            List<Person> Nacteno = new List<Person>();
            string[] radek = File.ReadAllLines(fileName);
            foreach (string item in radek)
            {

                string[] pole = item.Split(';');
                string jmeno = pole[0];
                string prijmeni = pole[1];
                string vekS = pole[2];
                Nacteno.Add(new Person(pole[0], pole[1] ));
            


            }
            return Nacteno;
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
