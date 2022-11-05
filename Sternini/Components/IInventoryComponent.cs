using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_csharp
{
    interface IInventoryComponent : IComponent
    {
        void AddCollectible(ICollectibleEntity entity);

        int GetQuantity(Type collectableType);
    }
}
