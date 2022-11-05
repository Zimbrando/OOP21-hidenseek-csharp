using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_csharp
{
    class InventoryComponent : AbstractComponent, IInventoryComponent
    {
        private ISet<ICollectibleEntity> _inventory;

        public InventoryComponent() => _inventory = new HashSet<ICollectibleEntity>();

        public void AddCollectible(ICollectibleEntity entity) => _inventory.Add(entity);

        public int GetQuantity(Type collectableType)
        {
            return _inventory
                        .Where(collectible => collectableType.IsInstanceOfType(collectible))
                        .Count();
        }
    }
}
