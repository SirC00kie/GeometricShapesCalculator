using GeometricShapesCalculator.GeometricShapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class AreaCalculatorTests
{
    [Theory]
    [InlineData(5, 25 * Math.PI)]
    [InlineData(7, 49 * Math.PI)]
    [InlineData(9, 81 * Math.PI)]
    public void CalculateArea_ShouldReturnCorrectAreaForCircle(double r, double expected)
    {
        // Arrange
        var circle = new Circle(r);

        // Act
        var result = AreaCalculator.Calculate(circle);
            
        // Assert
        Assert.Equal(expected, result, 2);
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(8, 15, 17, 60)]
    public void CalculateArea_ShouldReturnCorrectAreaForTriangle(double a, double b, double c, double expected)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var result = AreaCalculator.Calculate(triangle);
            
        // Assert
        Assert.Equal(expected, result, 2);
    }
}