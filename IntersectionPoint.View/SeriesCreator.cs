using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace IntersectionPoint.View
{
    internal class SeriesCreator
    {
        public static Series CreateLine(string name,Vector2 vector1, Vector2 vector2)
        {
            var series = new Series()
            {
                Name = name,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Double,   
                ChartType = SeriesChartType.Line              
            };

            series.Points.Add(new DataPoint(vector1.X, vector1.Y));
            series.Points.Add(new DataPoint(vector2.X, vector2.Y));

            return series;
        }

        public static Series CreateDot(Vector2 vector)
        {
            return new Series()
            {

            };
        }
    }
}
