using System.Collections.Generic;
using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public interface IHitbox
    {
        IReadOnlyCollection<Point> Points { get; }

        void AddPoint(Point point);
        Point GetBounds();
    }
}
