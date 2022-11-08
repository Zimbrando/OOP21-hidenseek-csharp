using System.Collections.Generic;

namespace Fragozzi.Model.Entities
{
    public interface IEntity
    {
        void Attach(IComponent component);
        void Detach<T>(T component) where T : IComponent;
        ICollection<IComponent> GetComponents();
        T GetComponent<T>(T component) where T : IComponent;
        bool HasComponent<T>(T component) where T : IComponent;
    }
}
