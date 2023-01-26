using GeometricShapesCalculator.GeometricShapes;

namespace GeometricShapesCalculator;

public static class AreaCalculator
{
    public static double Calculate(IGeometricShape shape)
    {
        return shape.Area();
    }
}