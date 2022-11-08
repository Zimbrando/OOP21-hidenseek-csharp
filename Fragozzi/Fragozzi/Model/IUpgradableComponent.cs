using Fragozzi.Model.Entities;

namespace Fragozzi.Model
{
    public interface IUpgradableComponent : IComponent
    {
        void Reset();

        bool IsUpgraded();
    }
}
