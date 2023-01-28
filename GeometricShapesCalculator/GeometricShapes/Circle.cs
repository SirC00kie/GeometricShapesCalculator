namespace GeometricShapesCalculator.GeometricShapes;

public class Circle : IGeometricShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше нуля");
        }
        this._radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}