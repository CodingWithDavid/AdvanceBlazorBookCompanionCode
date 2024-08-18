using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Composite
{
    public interface IFormComponent
    {
        RenderFragment Render();
    }
}
