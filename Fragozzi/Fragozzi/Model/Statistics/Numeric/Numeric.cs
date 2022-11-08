using System;

namespace Fragozzi.Model.Statistics.Numeric
{
    public class Numeric : IStatisticProperty<int>
    {
        public int Value { get; set; }

        public Numeric(int value)
        {
            Value = value;
        }

        public void Increase(int diff)
        {
            Value += diff;
        }

        public void Decrease(int diff)
        {
            Value = Math.Max(0, Value - diff);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
