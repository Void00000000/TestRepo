﻿namespace GitTestApp
{
    internal class Point
    {
        public double x;
        public double y;
        public double z;
        public double length;
        public override string ToString()
        {
            return $"Point: {nameof(x)} = {x}, {nameof(y)} = {y} {nameof(y)} = {z}";
        }
    }
}
