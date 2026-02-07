using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("950 W 190th St.", "Torrance", "CA", "USA");
        Address addr2 = new Address("27 St. Anne Ct.", "London", "GB", "United Kingdom");

        Customer cust1 = new Customer("Sherry Wells", addr1);
        Customer cust2 = new Customer("Elizabeth Windsor", addr2);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Aloe Concentrate", "F123", 10.0, 2));
        order1.AddProduct(new Product("Protein Powder", "A987", 20.5, 1));

        Order order2 = new Order(cust1);
        order2.AddProduct(new Product("Fish Tacos", "E789", 15.0, 3));
        order2.AddProduct(new Product("Vinegar Chips", "C321", 12.0, 2));

        PrintOrder(order1);
        PrintOrder(order2);
    }

    static void PrintOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: {order.GetTotalPrice():C}");
        Console.WriteLine("------------------------------\n");
    }
}