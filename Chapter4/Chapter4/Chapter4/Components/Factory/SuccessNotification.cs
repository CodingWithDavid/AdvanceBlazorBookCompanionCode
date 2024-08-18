using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Factory
{
    public class SuccessNotification : INotification
    {
        public RenderFragment Render() => builder =>
        {
            builder.AddContent(0, "Success: Operation completed successfully.");
        };

    }
}
