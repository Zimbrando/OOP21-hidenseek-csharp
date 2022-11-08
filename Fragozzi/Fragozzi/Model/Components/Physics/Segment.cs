using System;
using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public class Segment : ISegment
    {
        public Point Point1 { get; }
        public Point Point2 { get; }

        public Segment(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
        }

        public Point? IntersectingTo(ISegment segment)
        {
            Point s1p1 = Point1;
            Point s1p2 = Point2;
            Point s2p1 = segment.Point1;
            Point s2p2 = segment.Point2;

            //calculate segments slope
            int dy1 = (int)s1p2.Y - (int)s1p1.Y;
            int dx1 = (int)s1p1.X - (int)s1p2.X;
            int c1 = dy1 * (int)s1p1.X + dx1 * (int)s1p1.Y;
            int dy2 = (int)s2p2.Y - (int)s2p1.Y;
            int dx2 = (int)s2p1.X - (int)s2p2.X;
            int c2 = dy2 * (int)s2p1.X + dx2 * (int)s2p1.Y;

            //determinate if segments are parallel - intersection impossible
            double det = dy1 * dx2 - dy2 * dx1;
            if (det == 0d)
            {
                return null;
            }

            //intersection point between infinite lines
            double x = (dx2 * c1 - dx1 * c2) / det;
            double y = (dy1 * c2 - dy2 * c1) / det;
            Point point = new Point(x, y);

            //if intersection point is inside one of two segments, they intersects
            if (PointOnLine(s1p1, s1p2, point) && PointOnLine(s2p1, s2p2, point))
            {
                return point;
            }

            return null;
        }

        private bool PointOnLine(Point segmentPoint1, Point segmentPoint2, Point point)
        {
            return (Math.Min(segmentPoint1.X, segmentPoint2.X) <= point.X) &&
                   (Math.Max(segmentPoint1.X, segmentPoint2.X) >= point.X) &&
                   (Math.Min(segmentPoint1.Y, segmentPoint2.Y) <= point.Y) &&
                   (Math.Max(segmentPoint1.Y, segmentPoint2.Y) >= point.Y);
        }
    }
}
