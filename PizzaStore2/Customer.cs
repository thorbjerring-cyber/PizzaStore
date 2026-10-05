using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    public class Customer
    {
        static int idCounter = 0;
        public Customer(string name, string adress)
        {
            Name = name;
            Id = ++idCounter;
            Adress = adress;

        }

        public string Name { get; set; }
        public int Id { get; }
        public string Adress { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}, Adress: {Adress}";
        }

    }
}
