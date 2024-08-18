namespace Chapter4.Components.Dashboard
{
    public class DashboardState
    {
        private List<string> widgetTypes = new();
        public IReadOnlyList<string> WidgetTypes => widgetTypes.AsReadOnly();

        public event Action? OnChange;

        public void AddWidgetType(string widgetType)
        {
            widgetTypes.Add(widgetType);
            NotifyStateChanged();
        }

        public void RemoveWidgetType(string widgetType)
        {
            widgetTypes.Remove(widgetType);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
