
namespace Fragozzi.Model.Statistics.Score
{
    public class ScoreStatistic : Statistic<Score, double>
    {
        public ScoreStatistic(string name, string tag, string title)
            : base(name, tag, title, new Score(0))
        {

        }

        public override object GetValue()
        {
            return Property.Value.ToString();
        }
    }
}
