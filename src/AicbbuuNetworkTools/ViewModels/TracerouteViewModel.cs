using CommunityToolkit.Mvvm.ComponentModel;

namespace AicbbuuNetworkTools.ViewModels;

public partial class TracerouteViewModel : ObservableObject
{
    [ObservableProperty] private string _target = "baidu.com";
    [ObservableProperty] private int _maxHops = 30;
    [ObservableProperty] private string _result = "";
    [ObservableProperty] private bool _isRunning = false;

    public void StartTraceroute()
    {
        IsRunning = true;
        Result = $"正在 Traceroute {Target} ...";
    }
}
