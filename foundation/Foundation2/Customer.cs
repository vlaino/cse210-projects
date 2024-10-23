using System;

public class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer()
    {

    }

    public bool IsCustomerUSA()
    {
        return _customerAddress.IsInUSA(_customerAddress.GetCountry());

    }

    public void CustomerName()
    {
        Console.WriteLine("Your name: ");
        _name = Console.ReadLine();
        Console.WriteLine("");
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public void SetCustomerAddress(string address, string city, string stateProvince, string country)
    {
        _customerAddress = new(address: address, city: city, stateProvince: stateProvince, country:country);

    }

    public Address GetAddress()
    {
        return _customerAddress;
    }
}