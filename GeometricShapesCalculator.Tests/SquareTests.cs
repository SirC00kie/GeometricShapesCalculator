using GeometricShapesCalculator.GeometricShapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class SquareTests
{
    [Theory]
    [InlineData(1,1)]
    [InlineData(2, 4)]
    [InlineData(10, 100)]
    public void Area_ShouldReturnCorrectArea(double side, double expected)
    {
        // Arrange
        var square = new Square(side);
            
        // Act
        var result = AreaCalculator.Calculate(square);
            
        // Assert
        Assert.Equal(expected, result, 2);
    }
}