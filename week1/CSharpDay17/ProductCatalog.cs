public class ProductCatalog
{
    public string Name { get; private set; }
    private readonly List<Product> _products;

    public ProductCatalog(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name can not be null or whitespace", nameof(name));
        }
        Name = name.Trim();
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if(product == null)
        {
            throw new ArgumentNullException(nameof(product), "product can not be null");
        }
        foreach(Product existingProduct in _products)
        {
            if(existingProduct.Id == product.Id)
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

        string? normalizedId = id.Trim();

        foreach (Product product in _products)
        {
            if(product.Id == normalizedId)
            {
                return product;
            }
        }

        return null;
    }

    public bool RemoveProductById(string id)
    {
        
        
        Product? productToRemove = FindProductById(id);

        if(productToRemove == null)
        {
            return false;
        }
        return _products.Remove(productToRemove); //remove returns true if the item was successfully removed, false otherwise
    }

    public void DisplayProducts()
    {
        if(_products.Count == 0)
        {
            Console.WriteLine("No products in the catalog.");
            return;
        }
        foreach (Product product in _products)
        {
            product.DisplayInfo();
        }
    }
}