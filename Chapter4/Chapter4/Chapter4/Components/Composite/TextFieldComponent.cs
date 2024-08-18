using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Composite
{
    public class TextFieldComponent : IFormComponent
    {
        public RenderFragment Render() => builder =>
        {
            builder.AddContent(0, "<input type='text' />");
        };

    }
}
