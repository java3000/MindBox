

using MindBoxLib;

namespace MindBoxTest;

public class Tests
{
    [Test]
    public void TestCircleForValue()
    {
        IShape circle = new Circle(1d);
        Assert.AreEqual(3.1415926535897931d, circle.CalculateSquare());
    }

    [Test]
    public void TestCircleZeroArgument()
    {
        var ex = Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.That(ex.Message, Is.EqualTo("Радиус должен быть больше нуля"));
    }

    [Test]
    public void TestTriangleOrtho()
    {
        var triangle = new Triangle(3d, 4d, 5d);
        Assert.That(() => triangle.IsOrthogonal(), Is.EqualTo(true));
    }

    [Test]
    public void TestTriangleZeroSizedSides()
    {
        var ex = Assert.Throws<ArgumentException>(() => new Triangle(0d, 4d, 5d));
        Assert.That(ex.Message, Is.EqualTo("Должны быть положительные значения больше нуля"));
    }

    [Test]
    public void TestTriangleNotTriangle()
    {
        var ex = Assert.Throws<ArgumentException>(() => new Triangle(2d, 2d, 8d));
        Assert.That(ex.Message, Is.EqualTo("Указанные стороны не образуют треугольник"));
    }
}