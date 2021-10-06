using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
   
        public DateTime DateOfBird { get; set; }
        
        public Address HomeAdress { get; set; } 

        public Person()
        {
            HomeAdress = new Address();
            
            
        }

        public Person(string firstName, string lastName):this()
        {
            
            FirstName = firstName;
            LastName = lastName;
          
        }


        public string VypisDoSouboru()
        {
            return $"{FirstName};{LastName};{Age()}";
        }
        public override string ToString()
        {
            return $"Jméno: {FirstName}, příjmení: {LastName}, věk: {Age()}, Adresa: {HomeAdress.Street}, {HomeAdress.City}";
        }
        public int Age()
        {
            //DateTime 
            //TimeSpan rozdil = DateTime.Now.Subtract(DateOfBird);
            //return ()
            return 0;
        }
 
    }
}