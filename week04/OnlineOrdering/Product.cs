using System;

public class Products
{
    private int _productId;
    private int _productPrice;
    private int _productQuant;

    public Products(int ProductID)
    {
        _productId = ProductID;
    }
    public Products(int ProductPrice, int ProductQuant)
    {
        _productPrice = ProductPrice;
        _productQuant = ProductQuant;
    }
    public int GetTheTotal()
    {
        return (int)_productPrice * (int)_productQuant;
    }
}