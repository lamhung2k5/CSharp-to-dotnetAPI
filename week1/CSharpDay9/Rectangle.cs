public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        if (width <= 0)
        {
            throw new ArgumentException("chieu rong khong duoc am", nameof(width));
        }
        if (height <= 0)
        {
            throw new ArgumentException("chieu cao khong duoc am", nameof(height));
        }
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}