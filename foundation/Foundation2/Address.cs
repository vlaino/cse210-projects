using System;

public class Address

{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string address, string city, string stateProvince, string country)
    {
        _street = address;
        _city = city;
        _stateOrProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA(string country)
    {
        if (country == "USA") return true;
        else return false;
    }

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string DisplayAllAddress()
    {
        string allAddress = $"Street: {GetStreet()}\n City: {GetCity()} \n State Or Province: {GetStateOrProvince()} \n Country: {GetCountry()}";
        return allAddress;
    }
}