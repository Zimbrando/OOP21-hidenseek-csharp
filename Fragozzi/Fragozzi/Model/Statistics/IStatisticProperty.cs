using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragozzi.Model.Statistics
{
    public interface IStatisticProperty<T>
    {
        T Value { get; set; }
    }
}
