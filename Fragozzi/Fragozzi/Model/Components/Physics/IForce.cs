using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public interface IForce
    {
        string Identifier { get; }
        double Intensity { get; set; }        
        double Direction { get; set; }

        double GetXComponent();
        double GetYComponent();
    }
}
