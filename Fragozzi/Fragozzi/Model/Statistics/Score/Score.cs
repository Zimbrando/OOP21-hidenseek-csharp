
namespace Fragozzi.Model.Statistics.Score
{
    public class Score : IStatisticProperty<double>
    {
        private double _value;
        public double Value {
            get => _value;
            set
            {
                if (value > 5)
                {
                    _value = 5;
                }
                if (value < 0)
                {
                    _value = 0;
                }
                _value = value;
            }

        }
        public Score(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString("0.00") + "/5";
        }
    }
}
