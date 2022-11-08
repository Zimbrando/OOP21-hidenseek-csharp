using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public interface ISegment
    {
        Point Point1 { get; }
        Point Point2 { get; }

        Point? IntersectingTo(ISegment segment);
    }
}
