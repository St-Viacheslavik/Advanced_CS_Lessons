using System;

namespace OverloadedOps
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        #region Override Methods

        public override string ToString() => $"[X,Y] = [{X},{Y}]";

        public override bool Equals(object obj) => obj?.ToString() == ToString();

        public override int GetHashCode() => ToString().GetHashCode();
        
        int IComparable<Point>.CompareTo(Point point)
        {
            if (X > point.X && Y > point.Y) return 1;
            if (X < point.X && Y < point.Y) return -1;
            return 0;
        }

        #endregion
        
        #region OverloadedOperators

        public static Point operator + (Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);

        public static Point operator +(Point p1, int delta) => new Point(p1.X + delta, p1.Y + delta);

        public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);

        public static Point operator - (Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

        public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);

        public static Point operator * (Point p1, Point p2) => new Point(p1.X * p2.X, p1.Y * p2.Y);

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);

        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);

        public static bool operator > (Point p1, Point p2) => ((IComparable<Point>) p1).CompareTo(p2) > 0;

        public static bool operator >=(Point p1, Point p2) => ((IComparable<Point>)p1).CompareTo(p2) >= 0;

        public static bool operator <(Point p1, Point p2) => ((IComparable<Point>)p1).CompareTo(p2) < 0;

        public static bool operator <=(Point p1, Point p2) => ((IComparable<Point>)p1).CompareTo(p2) <= 0;

        #endregion
    }
}
