using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Composite
{
    public class CheckboxComponent : IFormComponent
    {
        public RenderFragment Render() => builder =>
        {
            builder.AddContent(0, "<input type='checkbox' />");
        };

    }
}
