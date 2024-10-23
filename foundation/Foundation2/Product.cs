using System;

public class Product
{
    private string _name;
    private string _ID;
    private float _price;
    private int _quantity;

    public Product()
    {

    }

    public void ProductName()
    {
        Console.WriteLine("Item name: ");
        _name = Console.ReadLine();
    }

    public string GetProduct()
    {
        return _name;
    }

    public void SetID()
    {
        string id = "";
        Random random = new();
        for (int i = 0; i < 8; i++)
        {
            id += random.Next(9);
        }
        _ID = $"#{id}";
    }

    public string GetID()
    {
        SetID();
        return _ID;
    }

    public void SetPrice()
    {
        Console.WriteLine("Price of item: $");
        _price = float.Parse(Console.ReadLine());
    }

    public float GetPrice()
    {
        return _price;
    }

    public void SetQuantity()
    {
        Console.WriteLine("Quantity: ");
        _quantity = int.Parse(Console.ReadLine());
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float Total()
    {
        return _price * _quantity;
    }
}