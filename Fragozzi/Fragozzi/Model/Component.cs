using Fragozzi.Model.Entities;

namespace Fragozzi.Model
{
    public abstract class Component : IComponent
    {
        private IEntity _owner = null;
        public IEntity Owner {
            get => _owner;
            set
            {
                if(_owner != null)
                {
                    throw new System.Exception("Owner already set");
                }
                _owner = value;
            }
        }

        public void Attach(IEntity entity)
        {
            entity.Attach(this);
        }

        public void Detach()
        {
            _owner = null;
        }
    }
}
