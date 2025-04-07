using System;

public class Products
{
    private string _productName;
    private string _productId;
    private int _productPrice;
    private int _productQuant;

    public Products(string ProductID)
    {
        _productId = ProductID;
    }
    public void SetProductsName(string ProductName)
    {
        _productName = ProductName;
    }
    public void GetThePrice (int ProductPrice, int ProductQuant)
    {
        _productPrice = ProductPrice;
        _productQuant = ProductQuant;
    }
    public int GetTheTotal()
    {
        return (int)_productPrice * (int)_productQuant;
    }
}