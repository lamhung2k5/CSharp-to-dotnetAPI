public class Circle : Shape
{
    public double R {  get; set; }
    public const double pi = 3.14;

    public Circle(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("ban kinh khong duoc am", nameof(r));
        }
        R = r;
    }

    public override double CalculateArea()
    {
        return pi * R * R;
    }
}