
public class Product
{
    // product ID
    private int _itemId;
    //Product Name
    private string _itemName;
    //Product cost
    private double _itemCost;
    //Product amount
    private int _quantity;
    //Product initializer for _product List in Order
    public Product(int itemId, string itemName, double itemCost)
    {
        _itemId = itemId;
        _itemName = itemName;
        _itemCost = itemCost;

    }
    //Product Initializer for _shopingCart List in Order
    public Product(int itemId, string itemName, double itemCost, int quantity = 1)
    {
        _itemId = itemId;
        _itemName = itemName;
        _itemCost = itemCost;
        _quantity = quantity;
    }
    //gets item ID
    public int GetId()
    {
        return _itemId;
    }
    //Gets item Name
    public string GetName()
    {
        return _itemName;
    }
    //Gets item Cost
    public double GetCost()
    {
        return _itemCost;
    }
    // Gets _shopingCart sum for a single item in cart dependent on quantity
    // the rest of the math for total is done in Order
    public double CostMultiplyer()
    {
        double sum = _itemCost * _quantity;
        return sum;
    }
    // Displays curent Product Info
    public void DisplayProductId()
    {
        Console.WriteLine($"{_itemName} ${_itemCost} ID: {_itemId}");
    }
    public void DisplayProductQuantity()
    {
        Console.WriteLine($"{_itemName} ${_itemCost} Amount: {_quantity}");
    }

}