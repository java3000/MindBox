namespace MindBoxLib;

public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius = default)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше нуля");
        }
        
        Radius = radius;
    }

    public double CalculateSquare()
    {
        return Math.PI * (Radius * Radius);
    }
}