using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP-001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS-002", 29.99, 2));
        order1.AddProduct(new Product("Keyboard", "KB-003", 79.99, 1));

        Address address2 = new Address("456 Maple Ave", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Johnson", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN-004", 349.99, 2));
        order2.AddProduct(new Product("USB Cable", "UC-005", 9.99, 5));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("=== ORDER ===\n");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine("\n");
        }
    }
}