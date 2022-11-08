using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragozzi.Model.Statistics
{
    public abstract class Statistic<T, U> : IStatistic<T, U> where T : IStatisticProperty<U>
    {
        public string Name { get; }

        public string Tag { get; }

        public string Title { get; }

        public T Property { get; }

        public Statistic(string name, string tag, string title, T property)
        {
            this.Name = name;
            this.Tag = tag;
            this.Title = title;
            this.Property = property;
        }

        public override bool Equals(object obj)
        {
            return obj == null &&
                obj.GetType().Equals(typeof(Statistic<T, U>)) &&
                ((Statistic<T, U>)obj).Name == Name &&
                ((Statistic<T, U>)obj).Tag == Tag;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Tag.GetHashCode();
        }

        public abstract object GetValue();
    }
}
