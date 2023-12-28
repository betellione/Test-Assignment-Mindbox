namespace Shapes.Test;

public class UnitTests
{

    [Fact]
    public void TestUnknownShape()
    {
        IShape shape = Random.Shared.NextDouble() < 0.5 ? new Circle(5) : new Triangle(3, 4, 5);
        var actualArea = shape.CalculateArea();
        var expectedArea = shape switch
        {
            Triangle => 6,
            Circle => Math.PI * Math.Pow(5, 2),
            _ => 0
        };

        Assert.Equal(expectedArea, actualArea, 0.00001);
    }
}