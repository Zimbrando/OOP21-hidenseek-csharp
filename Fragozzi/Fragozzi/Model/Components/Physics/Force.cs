using System;

namespace Fragozzi.Model.Components.Physics
{
    public class Force : IForce
    {
        public string Identifier { get; }
        public double Intensity { get; set; }
        public double Direction { get; set; }

        public Force(string identifier, double intensity, double direction)
        {
            this.Identifier = identifier;
            this.Intensity = intensity;
            this.Direction = direction;
        }

        public double GetXComponent()
        {
            return Intensity * Math.Cos(Math.PI / 180 * Direction);
        }

        public double GetYComponent()
        {
            return Intensity * Math.Sin(Math.PI / 180 * Direction);
        }
    }
}
