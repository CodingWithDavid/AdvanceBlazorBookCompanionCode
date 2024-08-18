namespace Chapter4.Components.Dashboard
{
    public class WidgetFactory
    {
        public IWidget CreateWidget(string widgetType) => widgetType switch
        {
            "chart" => new ChartWidget(),
            "list" => new ListWidget(),
            "notification" => new NotificationWidget(),
            _ => throw new ArgumentException("Invalid widget type")
        };

    }
}
