namespace GitTestApp
{
    internal class Point
    {
        public double x;
        public double y;
        public override string ToString()
        {
            return $"{nameof(x)} = {x}, {nameof(y)} = {y}";
        }
    }
}
