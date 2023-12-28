namespace Shapes;

/// <summary>
///     A class that represents a triangle.
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Triangle" /> class with three given sides.
    /// </summary>
    /// <param name="sideA">Side 1.</param>
    /// <param name="sideB">Side 2.</param>
    /// <param name="sideC">Side 3.</param>
    /// <exception cref="ArgumentOutOfRangeException">Throws an exception when one of the sides is less then or equal to zero.</exception>
    /// <exception cref="ArgumentException">Throws an exception when one of the sides is greater than the sum of the other two.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        Span<double> sides = stackalloc[] { sideA, sideB, sideC };
        sides.Sort();
        (SideA, SideB, SideC) = (sides[0], sides[1], sides[2]);
        ValidateArguments();
    }

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    /// <summary>
    ///     Indicates whether the triangle is right.
    /// </summary>
    public bool IsRight => Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) < 1E-10;

    public double CalculateArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    private void ValidateArguments()
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(SideA);
        if (SideA + SideB < SideC)
            throw new ArgumentException("The sum of 2 sides of a triangle cannot be less than the third");
    }
}