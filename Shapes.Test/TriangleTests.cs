namespace Shapes.Test;

public class TriangleTests
{
    [Fact]
    public void TestTriangleArea_WithCorrectSides()
    {
        // Arrange.
        var triangle = new Triangle(3, 4, 5);
        const int expectedArea = 6;
        // Act.
        var actualArea = triangle.CalculateArea();

        // Assert.
        Assert.Equal(expectedArea, actualArea, 0.00001);
    }

    [Fact]
    public void TestRightTriangle_WithCorrectSides()
    {
        // Arrange.
        var left = new Triangle(2, 4, 5);
        var right = new Triangle(3, 4, 5);

        // Assert.
        Assert.True(right.IsRight);
        Assert.False(left.IsRight);
    }

    [Fact]
    public void TestTriangle_WithNegativeSide()
    {
        // Assert.
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, 2, 5));
    }

    [Fact]
    public void TestTriangle_WithWrongSides()
    {
        // Assert.
        Assert.Throws<ArgumentException>(() => new Triangle(2, 2, 5));
    }
}