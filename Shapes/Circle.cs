namespace Shapes;

public class Circle : IShape
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Circle" /> class with given radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    /// <exception cref="ArgumentOutOfRangeException">Throws an exception when radius is less then or equal to zero.</exception>
    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius);
        Radius = radius;
    }

    public double Radius { get; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}