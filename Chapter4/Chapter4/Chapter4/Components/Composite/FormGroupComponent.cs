using Microsoft.AspNetCore.Components;

namespace Chapter4.Components.Composite
{
    public class FormGroupComponent : IFormComponent
    {
        private readonly List<IFormComponent> _children = new List<IFormComponent>();

        public void Add(IFormComponent component)
        {
            _children.Add(component);
        }

        public RenderFragment Render() => builder =>
        {
            foreach (var child in _children)
            {
                builder.AddContent(0, child.Render());
            }
        };

    }
}
