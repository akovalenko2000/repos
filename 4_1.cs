using System;

public class Square
{
    public double side;
	public Square()
	{
	}
    public Square(double side)
    {
        this.side = side;
    }
    public virtual double Perimeter(double side)
    { return 4 * side; }
    public virtual double Area(double side)
    { return side * side; }
}
