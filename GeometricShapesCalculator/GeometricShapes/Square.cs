namespace GeometricShapesCalculator.GeometricShapes;

public class Square : IGeometricShape
{
    private readonly double _side;

    public Square(double side)
    {
        this._side = side;
    }

    public double Area()
    {
        return Math.Pow(_side, 2);
    }
}