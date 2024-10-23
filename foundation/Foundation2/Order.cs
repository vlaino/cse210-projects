using System;

public class Order

{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();
    private int _USA = 5;
    private int _outsideUSA = 35;
    private int _shippingCost;
    private float _total;

    public Order()
    {

    }

    public void GetShippingInf()
    {
        foreach (Customer customer in _customers)
        {
            Address theAddress = customer.GetAddress();
            Console.WriteLine("\n Shipping inf: ");
            Console.WriteLine($"{theAddress.DisplayAllAddress()}");
            _shippingCost = customer.IsCustomerUSA() ? _USA : _outsideUSA;
        }
    }

    public int GetShippingCost()
    {
        return _shippingCost;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("\n Packing Label: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Item: {product.GetProduct()}, Item ID: {product.GetID()}");
        }
    }

    public float TotalCost()
    {
        foreach(Product product in _products)
        {
            _total += product.Total();
        }
        return _total + GetShippingCost();
    }

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public void AddProduct (Product item)
    {
        _products.Add(item);
    }

    public void DiplayShipping()
    {
        GetPackingLabel();
        GetShippingInf();
        Console.WriteLine($"\n Total Cost is: ${TotalCost()}");
    }
}

