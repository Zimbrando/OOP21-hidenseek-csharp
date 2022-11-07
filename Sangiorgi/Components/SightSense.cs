using System;
using System.Collections.Generic;
using OOP_csharp.Entities;


namespace OOP_csharp.Components
{
    class SightSense : AbstractSense
    {
        private int _sightRange;

        public SightSense(int sightRange)
        {
            _sightRange = sightRange;
        }

        public override eSenseConfidence senseCheck(IEntity e)
        {
            if (Owner == null)
            {
                return eSenseConfidence.NONE;
            }
            if (Owner.GetComponent(typeof(IPosition)) == null) {
                return eSenseConfidence.NONE;
            }
            if(e.GetComponent(typeof(IPosition)) == null) {
                return eSenseConfidence.NONE;
            }
            IPosition ownerPosComponent = ((IPosition)Owner.GetComponent(typeof(IPosition)));
            KeyValuePair<int, int> ownerPos = ownerPosComponent.Position;

            IPosition ePosComponent = ((IPosition)e.GetComponent(typeof(IPosition)));
            KeyValuePair<int, int> ePos = ePosComponent.Position;

            if(GetDistance(ownerPos.Key, ownerPos.Value, ePos.Key, ePos.Value) > _sightRange) {
                return eSenseConfidence.NONE;
            }
            return eSenseConfidence.HIGH;
        }

        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}

