using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Strategy
{
    public class LineChartStrategy : IChartStrategy
    {
        public RenderFragment RenderChart() => builder =>
        {
            builder.AddContent(0, "Rendering a Line Chart");
        };

    }
}
