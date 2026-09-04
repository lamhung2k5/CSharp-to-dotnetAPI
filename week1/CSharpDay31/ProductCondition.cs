public static class ProductCondition
{
    public static bool IsExpensive(Product product)
    {
        return product.Price >= 1000;
    }

    public static bool IsCheap(Product product)
    {
        return product.Price < 100;
    }
}