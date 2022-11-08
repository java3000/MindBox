namespace MindBoxLib;

public class Triangle : IShape
{
    private double A { get; }
    private double B { get; }
    private double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Должны быть положительные значения больше нуля");

        if (a + b < c || b + c < a || a + c < b)
            throw new ArgumentException("Указанные стороны не образуют треугольник");

        A = a;
        B = b;
        C = c;
    }

    public bool IsOrthogonal()
    {
        return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
    }

    public double CalculateSquare()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}