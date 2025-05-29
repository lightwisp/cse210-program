
public class Customer
{
    // customers Name
    private string _customerName;
    // initalizer variable for Address
    private Address _address;
    // initalizer for Customer class that also initalises Address class
    public Customer(string name, string street, string city, string stateOrProvince, string country)
    {
        _customerName = name;
        _address = new Address(street, city, stateOrProvince, country);
    }
    // check to see if cosomer lives in the USA
    // for total cost purposes
    public bool LivesInUS()
    {
        return _address.IsInUSA();
    }
    //Display all info about Costomer and Address classes
    public void DisplayCusomerInfo()
    {
        Console.WriteLine($"\n{_customerName}\n{_address.ReturnInfo()}\n");
    } 

}