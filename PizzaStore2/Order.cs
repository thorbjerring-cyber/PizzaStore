using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    public class Order
    {
        private static int orderNumberCounter = 0;
        private const double deliveryCost = 40;
        private const double VAT = 1.25;

        private List<Pizza> _pizzaList;
        public Order(Customer customer, bool needDelivery)
        {
            Ordernumber = ++orderNumberCounter;
            Customer = customer;
            NeedDelivery = needDelivery;
            _pizzaList =  new List<Pizza>();
        }

        public int Ordernumber { get; set; }

        public Customer Customer { get; }

        public bool NeedDelivery { get; set; }

        public List<Pizza> PizzaList
        {
            get { return _pizzaList; }
            set { _pizzaList = value; }
        }




        public void AddPizza(Pizza pizza)
        {
            _pizzaList.Add(pizza);
        }
        public double DeliveryFee()
        {
            int decider = NeedDelivery ? 1 : 0;
            return deliveryCost * decider;
        }
        public double CalculatePriceOfPizzas()
        {
            double sum = 0;
           foreach (Pizza item in _pizzaList)
            {
                sum = sum + item.Price;
            }
            return sum;
        }


        public double CalculateTotalPrice()
        {
            return CalculatePriceOfPizzas() * VAT + DeliveryFee();
        }

        public double VatDifference()
        {
            return (CalculatePriceOfPizzas() * VAT) - CalculatePriceOfPizzas();
        }

        public string GetAllPizzaString()
        {
            string stringSum = "";
            foreach (Pizza item in PizzaList)
            {
                stringSum = stringSum + item.ToString();
            }
            return stringSum;
        }


        public void PrintReciept()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------Reciept------");
            Console.WriteLine($"Order number : {Ordernumber}");
            Console.WriteLine($"Name : {Customer.Name}");
            foreach (Pizza item in _pizzaList)
            {
                Console.WriteLine($"Pizza : {item.Name} | price : {item.Price} kr");
            }
            Console.WriteLine($"VAT : {VatDifference()} kr (25%)");
            if (DeliveryFee() != 0)
            {
                Console.WriteLine($"Delivery fee : {DeliveryFee()} kr");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine($"Total price : {CalculateTotalPrice()} kr");
        }

        public override string ToString()
        {
            return $"Ordernumber: {Ordernumber}, Total price: {CalculateTotalPrice()} Pizzas: {GetAllPizzaString()}, Customer: {Customer.ToString()}";
        }



    }
}
