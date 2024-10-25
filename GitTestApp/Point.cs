namespace GitTestApp
{
    internal class Point
    {
        public double x;
        public double y;
        public double z;
        public override string ToString()
        {
            return $"{nameof(x)} = {x}, {nameof(y)} = {y}";
        }
    }
}
