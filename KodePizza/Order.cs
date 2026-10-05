using System;
using System.Collections.Generic;
using System.Text;

namespace KodePizza
{
    public class Order
    {
        private static int orderNumberCounter = 0;
        private const double deliveryCost = 40;
        private const double VAT = 1.25;
        public Order(Pizza pizza, Customer customer, bool needDelivery)
        {
            Ordernumber = ++orderNumberCounter;
            Customer = customer;
            Pizza = pizza;
            NeedDelivery = needDelivery;
            
        }

        public int Ordernumber { get; set; }
        public Pizza Pizza { get; }
        public Customer Customer { get;  }

        public bool NeedDelivery { get; set; }



        public double DeliveryFee()
        {
            int decider = NeedDelivery ? 1 : 0;
            return deliveryCost * decider;
        }
        public double CalculateTotalPrice()
        {
            return (Pizza.Price * VAT) + DeliveryFee();
        }



        public void PrintReciept()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------Reciept------");
            Console.WriteLine($"Order number : {Ordernumber}");
            Console.WriteLine($"Name : {Customer.Name}");
            Console.WriteLine($"Pizza : {Pizza.Name} | price : {Pizza.Price} kr");
            Console.WriteLine($"VAT : {(Pizza.Price * VAT) - Pizza.Price} kr (25%)");
            Console.WriteLine($"Delivery fee : {DeliveryFee()} kr");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Total price : {CalculateTotalPrice()} kr");
        }

        public override string ToString()
        {
            return $"Ordernumber: {Ordernumber}, Total price: {CalculateTotalPrice()} Pizza: {Pizza.ToString()}, Customer: {Customer.ToString()}";
        } 



    }
}
