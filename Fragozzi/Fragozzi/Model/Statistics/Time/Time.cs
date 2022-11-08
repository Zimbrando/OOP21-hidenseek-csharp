using System;

namespace Fragozzi.Model.Statistics.Time
{
    public class Time : IStatisticProperty<TimeSpan>
    {
        public TimeSpan Value { get; set; }

        public Time(TimeSpan value)
        {
            Value = value;
        }
        public void AddTime(int seconds)
        {
            Value = Value.Add(TimeSpan.FromSeconds(seconds));
        }
        public void SubtractTime(long seconds)
        {
            Value = Value.Subtract(TimeSpan.FromSeconds(seconds));
        }
        public override string ToString()
        {
            return string.Format("{0}h {1}m", ((int)Value.TotalHours), ((int)Value.Minutes));
        }
    }
}
