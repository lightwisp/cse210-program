using System.Reflection;
public class Order
{
    // list for available items to put into _shopingCart
    private List<Product> _products = new List<Product>();
    // list of items in _shopingCart
    private List<Product> _shopingCart = new List<Product>();
    //Initalizing a variable for Customer class
    private Customer customer;

    // file pathing for csv file that holds all of product data
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    static string oldFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    static string  filePath = oldFolderPath.Replace(@"\bin\Debug\net8.0", "");
    private string[] files = Directory.GetFiles(filePath, "*.csv");
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // so i can initialize withougt adding customer info
    // this is so i can print all items in the _products list
    public Order()
    {
        GetItems();
    }
    //Order Initializer
    public Order(string name, string street, string city, string stateOrProvince, string country)
    {
        customer = new Customer(name, street, city, stateOrProvince, country);
        //gathers all product data and adds them to _products
        GetItems();
    }
    //Adds items to _shopingCart
    public void AddToCart(int idNumber, int quantity)
    {
        foreach (Product product in _products)
        {
            if (product.GetId() == idNumber)
            {
                Product cart = new Product(product.GetId(), product.GetName(), product.GetCost(), quantity);
                _shopingCart.Add(cart);
            }

        }
    }
    // Displays all customer and _shopingCart Info including Total cost
    public void DisplayAllCartCustomerInfo()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        customer.DisplayCusomerInfo();
        double shiping = ShipingCost();
        double cartSum = AddCartTotal();
        double totalCost = Math.Round(cartSum + shiping, 2);
        DisplayCart();
        Console.WriteLine($"\nSubTotal: ${cartSum:0.00}\nShiping Cost: ${shiping}\nTotal Cost: ${totalCost:0.00}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
    // Gets cost of shiping for inside USA and out Side USA
    private double ShipingCost()
    {
        bool livesInUSA = customer.LivesInUS();
        if (livesInUSA == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    //Adds total cost of items added to _shopingCart
    private double AddCartTotal()
    {
        double total = 0;
        foreach (Product product in _shopingCart)
        {
            double sum = product.CostMultiplyer();
            total += sum;
        }
        return total;
    }
    //Displays _shopingCart
    private void DisplayCart()
    {
        int itemNumber = 1;
        foreach (Product product in _shopingCart)
        {
            Console.Write($"[{itemNumber}] ");
            product.DisplayProductQuantity();
            itemNumber++;
        }
    }
    // Displays _product List
    public void DisplayItems()
    {
        int itemNumber = 1;
        Console.WriteLine("Available Items:");
        foreach (Product product in _products)
        {
            Console.Write($"[{itemNumber}] ");
            product.DisplayProductId();
            itemNumber++;
        }
    }
    //Gathers items from csv file and addes them to _products
    private void GetItems()
    {
        foreach (string file in files)
        {
            foreach (string line in File.ReadLines(file).Skip(1))
            {
                string[] parts = line.Split(",");
                int part1 = int.Parse(parts[0]);
                string part2 = parts[1];
                double part3 = double.Parse(parts[2]);
                Product product = new Product(part1, part2, part3);
                //product.DisplayProduct();
                _products.Add(product);
            }
        }
    }
}