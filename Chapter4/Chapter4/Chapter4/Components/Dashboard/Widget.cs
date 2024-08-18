using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Dashboard
{
    public interface IWidget
    {
        RenderFragment Render();
    }
}
