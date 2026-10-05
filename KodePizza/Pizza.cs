using System;
using System.Collections.Generic;
using System.Text;

namespace KodePizza
{
    public class Pizza
    {
        private static int idcounter = 0;
        public Pizza(double price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;
            Id = ++idcounter;

        }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get;}

        public override string ToString()
        {
            return $"Price: {Price}, Name: {Name} Description: {Description} Id: {Id}";
        }
    }
}
