﻿using System;
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

        public int Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public string VypisDoSouboru()
        {
            return $"{FirstName};{LastName};{Age}";
        }
        public override string ToString()
        {
            return $"Jméno: {FirstName}, příjmení: {LastName}, věk: {Age}";
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}