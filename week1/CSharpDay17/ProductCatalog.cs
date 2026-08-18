public class ProductCatalog
{
    public string Name { get; set; }
    private readonly List<Product> _products;

    public ProductCatalog(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name can not be null or whitespace", nameof(name));
        }
        Name = name;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if(product == null)
        {
            throw new ArgumentNullException("product can not be null", nameof(product));
        }
        foreach(Product IsExistsProduct in _products)
        {
            if(IsExistsProduct.Id == product.Id)
            {
                throw new InvalidOperationException("Product with the same ID already exists");
            }
        }
        _products.Add(product);
    }

    public Product? FindProductById(string id)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id cant not be null or whitespace", nameof(id));
        }

        foreach(Product product in _products)
        {
            if(product.Id == id)
            {
                return product;
            }
        }

        return null;
    }

    public bool RemoveProductById(string id)
    {
        foreach(Product product in _products)
        {
            if(product.Id == id)
            {
                _products.Remove(product);
                return true;
            }
        }
        return false;
    }

    public void DisplayProducts()
    {
        foreach (Product product in _products)
        {
            product.DisplayInfo();
        }
    }
}