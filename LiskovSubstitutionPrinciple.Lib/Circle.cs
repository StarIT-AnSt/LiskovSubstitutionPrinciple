namespace LiskovSubstitutionPrinciple.Lib;

public class Circle : IFigure
{
    private const double PI = 3.14;

    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalcArea()
    {
        return PI * _radius * _radius;
    }

    public double CalcPerimeter()
    {
        return 2 * PI * _radius;
    }
}
