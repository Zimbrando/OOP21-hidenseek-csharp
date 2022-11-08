using Fragozzi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Fragozzi.Model.Components.Physics
{
    public class MoveComponent : Component, IMoveComponent
    {
        private readonly double _defaultSpeed;
        private IList<IForce> _forces = new List<IForce>();

        public double Speed { get; set; }
        public IReadOnlyCollection<IForce> Forces { 
            get => new ReadOnlyCollection<IForce>(_forces); 
        }

        public MoveComponent(double defaultSpeed)
        {
            _defaultSpeed = defaultSpeed;
        }

        public void AddForce(IForce force)
        {
            _forces.Add(force);
        }

        public IForce GetResultantForce()
        {
            throw new NotImplementedException();
        }

        public bool IsUpgraded()
        {
            throw new NotImplementedException();
        }

        public void RemoveForce(IForce force)
        {
            _forces.Remove(force);
        }

        public void RemoveForce(Predicate<IForce> removeCondition)
        {
            _forces = _forces.Where(x => removeCondition.Invoke(x)).ToList();
        }

        public void Reset()
        {
            Speed = _defaultSpeed;
        }
    }
}
