namespace Chapter4.Components.Factory
{
    public class NotificationFactory
    {
        public INotification CreateNotification(string type) => type switch
        {
            "success" => new SuccessNotification(),
            "error" => new ErrorNotification(),
            "warning" => new WarningNotification(),
            _ => throw new ArgumentException("Invalid notification type")
        };

    }
}
