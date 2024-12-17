namespace Task;

public class ShoppingCart
{
    private List<Product> _products;

    public Product AddProduct(Product product)  
    {
        _products.Add(product);
        return product;
    }

}
