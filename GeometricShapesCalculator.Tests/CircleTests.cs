using GeometricShapesCalculator.GeometricShapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 1 * Math.PI)]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(10, 100 * Math.PI)]
    public void Area_ShouldReturnCorrectArea(double radius, double expected)
    {
        // Arrange
        var circle = new Circle(radius);
            
        // Act
        var result = AreaCalculator.Calculate(circle);
            
        // Assert
        Assert.Equal(expected, result, 2);
    }
}