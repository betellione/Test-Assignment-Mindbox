namespace Shapes.Test;

public class CircleTests
{
    [Fact]
    public void TestCircleArea_WithCorrectRadius()
    {
        // Arrange.
        var circle = new Circle(5);
        var expectedArea = Math.PI * Math.Pow(5, 2);

        // Act.
        var actualArea = circle.CalculateArea();

        // Assert.
        Assert.Equal(expectedArea, actualArea, 0.00001);
    }

    [Fact]
    public void TestCircle_WithNegativeRadius()
    {
        // Assert.
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }
}