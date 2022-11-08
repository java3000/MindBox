

using MindBoxLib;

IShape shape = new Circle(1d);
IShape shape2 = new Triangle(1d, 1d, 1d);

Console.WriteLine(shape.CalculateSquare());
Console.WriteLine(shape2.CalculateSquare());