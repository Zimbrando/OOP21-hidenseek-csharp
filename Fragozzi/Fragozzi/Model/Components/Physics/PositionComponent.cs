using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public class PositionComponent : Component, IPositionComponent
    {
        public Point Position { get; set; }
    }
}
