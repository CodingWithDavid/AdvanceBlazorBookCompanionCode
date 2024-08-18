using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Dashboard
{
    public class ListWidget :IWidget
    {
        public RenderFragment Render() => builder =>
        {
            builder.AddContent(0, "Rendering a List Widget");
        };

    }
}
