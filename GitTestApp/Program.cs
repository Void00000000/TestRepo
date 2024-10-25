Point2D point = new Point2D() { x = 2, y = 2};
Console.WriteLine(point.ToString());
class Point2D
{
    public double x;
    public double y;
    public override string ToString()
    {
        return $"{nameof(x)} = {x}, {nameof(y)} = {y}";
    }
}