using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Factory
{
    public interface INotification
    {
        RenderFragment Render();
    }
}
