using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Factory
{
    public class ErrorNotification : INotification
    {
        public RenderFragment Render() => builder =>
        {
            builder.AddContent(0, "Error: Something went wrong.");
        };

    }
}
