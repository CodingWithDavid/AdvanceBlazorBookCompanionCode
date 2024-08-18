using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Strategy
{
    public interface IChartStrategy
    {
        RenderFragment RenderChart();
    }

}
