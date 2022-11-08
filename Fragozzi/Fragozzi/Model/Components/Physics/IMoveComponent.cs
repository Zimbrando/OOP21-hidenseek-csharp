using System;
using System.Collections.Generic;

namespace Fragozzi.Model.Components.Physics
{
    public interface IMoveComponent : IUpgradableComponent
    {
        double Speed { get; set; }
        IReadOnlyCollection<IForce> Forces { get; }

        void AddForce(IForce force);
        void RemoveForce(IForce force);
        void RemoveForce(Predicate<IForce> removeCondition);
        IForce GetResultantForce();
    }
}
