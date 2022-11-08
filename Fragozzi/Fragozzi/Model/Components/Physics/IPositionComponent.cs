using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public interface IPositionComponent : IComponent
    {
        Point Position { get; set; }
    }
}
