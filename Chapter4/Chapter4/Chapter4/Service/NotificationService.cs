namespace Chapter4.Service
{
    public class NotificationService
    {
        public event Action<string>? OnNotification;

        public void Notify(string message)
        {
            OnNotification?.Invoke(message);
        }

    }
}
