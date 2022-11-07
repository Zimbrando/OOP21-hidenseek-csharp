using System;
using System.Collections.Generic;

namespace OOP_csharp.Components
{

    class GoodHeart : AbstractHeart
    {
        private ISet<eHeart> _hated; // hated hearts

        public GoodHeart()
        {
            _hated = new HashSet<eHeart>();
            _hated.Add(eHeart.EVIL);
            setHeart(eHeart.GOOD);
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

