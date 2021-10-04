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
            Console.WriteLine("Vložte jméno:");
            string input = Console.ReadLine();
            if(input==null || input.Length < 1)
            {
                Console.WriteLine($"Není koho pozdravit");
                return;
            }
            
            if (input.ToLower() == "bob" || input.ToLower() == "alice")
            {
                Console.WriteLine("Vítej zpět!");
                return;
            }
            Console.WriteLine($"Vítej {input}.");



           
            
        }





    }
}
