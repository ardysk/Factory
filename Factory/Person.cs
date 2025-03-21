using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Person
    {
        public string name { get; private set; }
        public string surname { get; private set; }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public abstract int Cost(int months); //abstract so u need to override in child class
        public override string ToString() //Person basic info 
        {
            return $"Name: {name} {surname}";
        } 
    }
}
