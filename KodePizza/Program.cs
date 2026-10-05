using KodePizza;


Customer customer1 = new Customer("Jørgen", "Jørgensvej 1");
Customer customer2 = new Customer("Børge", "Roladegade 4");
Customer customer3 = new Customer("Signe", "Luksusvej 41");

Pizza pizza1 = new Pizza(89, "Valencia", "ost, tomat, pepperoni, skine, champingonger, paprika");
Pizza pizza2 = new Pizza(129, "Svampebob", "ost, tomat, skinke, champingonger, spids-nøgenhat, rød fluesvamp");
Pizza pizza3 = new Pizza(79, "Hawaii", "ost, tomat, ananas, skinke");

Order order1 = new Order(pizza1, customer1,true);
Order order2 = new Order(pizza2, customer2,false);
Order order3 = new Order(pizza3, customer3,true);


Console.WriteLine(order1.ToString());


Console.WriteLine(order3.ToString());



order3.PrintReciept();
