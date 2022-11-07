using System;
using System.Collections.Generic;

namespace OOP_csharp.Components
{
    class EvilHeart : AbstractHeart
    {
        private ISet<eHeart> _hated; // hated hearts

        public EvilHeart()
        {
            _hated = new HashSet<eHeart>();
            _hated.Add(eHeart.GOOD);
            setHeart(eHeart.EVIL);
        }

        public override bool Hates<T>(T e)
        {
            return false;
        }

        public override bool Loves<T>(T e)
        {
            return false;
        }
    }
}

