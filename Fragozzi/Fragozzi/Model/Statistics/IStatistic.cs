using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragozzi.Model.Statistics
{
    public interface IStatistic<T, U> where T : IStatisticProperty<U>
    {
        string Name { get; }
        string Tag { get; }
        string Title { get; }
        T Property { get; }

        object GetValue();
    }
}
