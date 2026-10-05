using PizzaStore2;

Customer customer1 = new Customer("Jørgen", "Jørgensvej 1");
Customer customer2 = new Customer("Børge", "Roladegade 4");
Customer customer3 = new Customer("Signe", "Luksusvej 41");

Pizza pizza1 = new Pizza(89, "Valencia", "ost, tomat, pepperoni, skine, champingonger, paprika");
Pizza pizza2 = new Pizza(129, "Svampebob", "ost, tomat, skinke, champingonger, spids-nøgenhat, rød fluesvamp");
Pizza pizza3 = new Pizza(79, "Hawaii", "ost, tomat, ananas, skinke");

Order order1 = new Order(customer1, true);
Order order2 = new Order(customer2, false);
Order order3 = new Order(customer3, true);


order1.AddPizza(pizza1);

order1.AddPizza(pizza2);

order1.PrintReciept();

Console.WriteLine(order1.ToString());



//List<Pizza> pizzaer = new List<Pizza>();