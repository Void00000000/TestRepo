Point2D point1 = new Point2D() { x = 2, y = 2};
Point2D point2 = new Point2D() { x = 3, y = 3 };
Console.WriteLine(point1.ToString());
class Point2D
{
    public double x;
    public double y;
    public override string ToString()
    {
        return $"{nameof(x)} = {x}, {nameof(y)} = {y}";
    }
}