namespace LiskovSubstitutionPrinciple.Lib;

public class Rectangle : IFigure
{
    private readonly double _sideA;
    private readonly double _sideB;

    public Rectangle(double sideA, double sideB)
    {
        _sideA = sideA;
        _sideB = sideB;
    }

    public double CalcArea()
    {
        return _sideA * _sideB;
    }

    public double CalcPerimeter()
    {
        return (_sideA + _sideB) * 2;
    }
}
