
namespace Fragozzi.Model.Statistics.Numeric
{
    public class NumericStatistic : Statistic<Numeric, int>
    {
        public string Units { get; }

        public NumericStatistic(string name, string tag, string title, string units)
            : base(name, tag, title, new Numeric(0))
        {
            Units = units;
        }

        public NumericStatistic(string name, string tag, string title)
            : this(name, tag, title, "")
        {
            
        }
        public override object GetValue()
        {
            return Property.Value.ToString();
        }
    }
}
