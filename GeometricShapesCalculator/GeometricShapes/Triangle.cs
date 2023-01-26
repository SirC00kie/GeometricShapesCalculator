namespace GeometricShapesCalculator.GeometricShapes;

public class Triangle : IGeometricShape
{
    private readonly double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Area()
    {
        var s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    
    public bool IsRight()
    {

        return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
               Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
               Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2);
    }
}