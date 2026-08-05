public class Product
{
    public string Id { get; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string id, string name, decimal price, int quantity)
    {
        if(string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("id khong duoc de trong", nameof(id));
        }
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("name khong duoc de trong", nameof(name));
        }
        if (price <= 0)
        {
            throw new ArgumentException("price khong duoc am", nameof(price));
        }
        if (quantity < 0)
        {
            throw new ArgumentException("quantity khong duoc am", nameof(quantity));
        }
        Id = id.Trim();
        Name = name.Trim();
        Price = price;
        Quantity = quantity;
    }

    public void ImportStock(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("so luong khong duoc am", nameof(quantity));
        }
        Quantity += quantity;
    }

    public void Sell(int quantity) 
    {
        if(quantity <= 0)
        {
            throw new ArgumentException("so luong ban khong duoc am", nameof(quantity));
        }
        if(quantity > Quantity) 
        {
            throw new InvalidOperationException("so luong ban khong duoc lon hon so luong ton kho");
        }
        Quantity -= quantity;
    }

    public decimal CalculateInventoryValue() 
    {
        return Price * Quantity;
    }

    public bool IsOutOfStock()
    {
        return Quantity == 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"id: {Id}, name: {Name}, price: {Price}, quantity: {Quantity}, Inventory Value: {CalculateInventoryValue()}, Stock: {(IsOutOfStock() ? "Out of Stock" : "In Stock")}");
    }

}