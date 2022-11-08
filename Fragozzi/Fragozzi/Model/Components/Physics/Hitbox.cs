using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public class Hitbox : IHitbox
    {
        private readonly IList<Point> _point = new List<Point>();
        public IReadOnlyCollection<Point> Points
        {
            get => new ReadOnlyCollection<Point>(_point);
        }

        public void AddPoint(Point point)
        {
            _point.Add(point);
        }

        public Point GetBounds()
        {
            throw new System.NotImplementedException();
        }
    }
}
