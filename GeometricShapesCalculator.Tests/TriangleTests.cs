using GeometricShapesCalculator.GeometricShapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(8, 15, 17, true)]
    [InlineData(7, 12, 15, false)]
    public void IsRight_ShouldReturnTrue_WhenTriangleIsRight(double a, double b, double c, bool expected)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);
            
        // Act
        var result = triangle.IsRight();
            
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(8, 15, 17, 60)]
    public void Area_ShouldReturnCorrectArea(double a, double b, double c, double expected)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);
            
        // Act
        var result = AreaCalculator.Calculate(triangle);
            
        // Assert
        Assert.Equal(expected, result, 2);
    }
}