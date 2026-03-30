using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Derek Jeter", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Samsung Galaxy S26 Ultra Smartphone", "P100", 1500, 1));
        order1.AddProduct(new Product("Samsung Leather Phone Cover", "P200", 20, 2));

        // Order 2 (International customer)
        Address address2 = new Address("Olmos 111 y Camino Real", "Guayaquil", "Guayas", "Ecuador");
        Customer customer2 = new Customer("Juan Estrella", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("On Running Shoes", "P300", 200, 1));
        order2.AddProduct(new Product("On Running Shoes Cleaning Kit", "P400", 25, 3));

        // Display Order 1
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        // Display Order 2
        Console.WriteLine("\n=== ORDER 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}