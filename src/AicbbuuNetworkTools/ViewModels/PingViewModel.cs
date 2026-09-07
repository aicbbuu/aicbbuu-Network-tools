using CommunityToolkit.Mvvm.ComponentModel;

namespace AicbbuuNetworkTools.ViewModels;

public partial class PingViewModel : ObservableObject
{
    [ObservableProperty] private string _target = "8.8.8.8";
    [ObservableProperty] private int _timeoutMs = 3000;
    [ObservableProperty] private string _result = "";
    [ObservableProperty] private bool _isRunning = false;

    public void StartPing()
    {
        IsRunning = true;
        Result = $"正在 Ping {Target} ...";
        // Service call would go here
    }
}
