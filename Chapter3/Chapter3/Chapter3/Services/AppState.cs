using System.Net.NetworkInformation;

namespace Chapter3.Services
{
    public class AppState
    {
        public string Theme { get; set; } = "Light";

        public event Action? OnChange;

        public void SetTheme(string theme)
        {
            Theme = theme;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
