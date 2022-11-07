using System;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    interface IHeart : IComponent
    {
        eHeart Heart { get; }

        Boolean Hates<T>(T e) where T : IEntity;

        Boolean Loves<T>(T e) where T : IEntity;

    }
}

