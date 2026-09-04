public class Product
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        //khong validation vi dang lam cho gon code lam cho nhanh
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price}";
    }
}