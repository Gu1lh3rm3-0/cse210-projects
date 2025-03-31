using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string GetAddress()
    {
        string address = $"{_street}, {_city}, {_state}, {_country}";
        return address;
    }
}