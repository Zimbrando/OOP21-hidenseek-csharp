using System;

namespace Fragozzi.Model.Statistics.Time
{
    public class TimeStatistic : Statistic<Time, TimeSpan>
    {

        public TimeStatistic(string name, string tag, string title)
            : base(name, tag, title, new Time(TimeSpan.FromSeconds(0)))
        {
        }

        public override object GetValue()
        {
            return Property.Value.ToString();
        }
    }
}
