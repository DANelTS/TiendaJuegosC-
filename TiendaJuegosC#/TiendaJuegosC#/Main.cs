using System;

public class Program
{
    public static void Main()
    {
        Customer cust = new Customer(1, "test", 150);

        Console.WriteLine(cust.ToString());
    }
}