public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(6),
                new Rectangle(4, 6),
                new Rectangle(2, 3)
            };

            double sumArea = 0;

            foreach (Shape s in shapes)
            {
                sumArea += s.CalculateArea();
            }
            Console.WriteLine(sumArea);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}