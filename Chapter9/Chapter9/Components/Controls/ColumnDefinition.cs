using Microsoft.AspNetCore.Components;

namespace Chapter9.Components.Controls
{
    public class ColumnDefinition<T>
    {
        public string Header { get; set; } = string.Empty;
        public string SortProperty { get; set; } = string.Empty;
        public Func<T, object> ValueSelector { get; set; }
        public RenderFragment<T> CellTemplate { get; set; }
        public Func<object, string> Formatter { get; set; }
    }
}
