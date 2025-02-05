class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Las Acacias 0465", "Villa Alemana", "V region", "Chile");
        Address address2 = new Address("1600 Pennsylvania Avenue NW", "Washington", "DC", "Usa");
       
        Customer customer1 = new Customer("Paz Orrego", address1);
        Customer customer2 = new Customer("Constanza Orrego", address2);

        Product product1 = new Product("Laptop", "P1001", 999.99, 1);
        Product product2 = new Product("Mouse", "P1002", 19.99, 2);
        Product product3 = new Product("Keyboard", "P1003", 49.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
    }
}
