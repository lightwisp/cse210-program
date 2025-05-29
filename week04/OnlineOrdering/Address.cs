
public class Address
{
    //Address variables for street, city, state/provic, country
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    //Address initializer
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    //checking if Customer is in USA for shiping cost
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }
    //Returns all of location info
    public string ReturnInfo()
    {
        string fullAddress = $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
        return fullAddress;
    }

}