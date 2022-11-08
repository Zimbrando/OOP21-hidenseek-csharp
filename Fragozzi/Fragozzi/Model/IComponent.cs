using Fragozzi.Model.Entities;

namespace Fragozzi.Model
{
    public interface IComponent
    {
        IEntity Owner { get; }

        void Attach(IEntity entity);

        void Detach();
    }
}
