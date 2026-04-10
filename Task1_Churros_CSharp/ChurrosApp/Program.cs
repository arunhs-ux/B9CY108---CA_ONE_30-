
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<Order> orders = new Queue<Order>();
        int orderCounter = 1;

        Dictionary<int, Churros> menu = new Dictionary<int, Churros>()
        {
            {1, new Churros("Plain Sugar", 6)},
            {2, new Churros("Cinnamon Sugar", 6)},
            {3, new Churros("Chocolate", 8)},
            {4, new Churros("Nutella", 8)}
        };

        while (true)
        {
            Console.WriteLine("\n1. Place Order\n2. Deliver Order\n0. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                foreach (var item in menu)
                    Console.WriteLine($"{item.Key}. {item.Value.Name} - €{item.Value.Price}");

                int opt = int.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                Order o = new Order(orderCounter++, menu[opt].Name, qty);
                o.PayBill(menu[opt].Price);

                orders.Enqueue(o);
            }
            else if (choice == 2)
            {
                if (orders.Count > 0)
                {
                    orders.Dequeue().Display();
                }
            }
            else break;
        }
    }
}
