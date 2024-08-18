using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Factory
{
    public class WarningNotification : INotification
    {
        public RenderFragment Render() => builder =>
        {
            builder.AddContent(0, "Warning: Check your inputs.");
        };

    }
}
