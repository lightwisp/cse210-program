using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Order itemList = new Order();
        itemList.DisplayItems();

        Order order01 = new Order("Wiliam", "4528 w Vermont Ave.", "Balingo", "Texes", "USA");
        order01.AddToCart(5, 3);
        order01.AddToCart(18, 5);
        order01.AddToCart(1, 6);
        order01.AddToCart(9, 2);
        order01.AddToCart(3, 1);
        order01.DisplayAllCartCustomerInfo();

        Order order02 = new Order("Sharlet Dimill", "3636 S Hailstorm C.", "Naomi", "Nunofa", "Belgum");
        order02.AddToCart(10, 6);
        order02.AddToCart(17, 5);
        order02.AddToCart(11, 2);
        order02.AddToCart(8, 4);
        order02.AddToCart(16, 10);
        order02.DisplayAllCartCustomerInfo();
    }
}