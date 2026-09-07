using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using AicbbuuNetworkTools.Views;

namespace AicbbuuNetworkTools.ViewModels;

public sealed partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private ModuleItem? _selectedModule;
    [ObservableProperty] private string _statusMessage = "就绪";

    public ObservableCollection<ModuleItem> Modules { get; } = new();

    private readonly PingViewModel _pingVM = new();
    private readonly TracerouteViewModel _tracerVM = new();

    public MainViewModel()
    {
        Modules.Add(new ModuleItem
        {
            Key = "Ping",
            DisplayName = "Ping",
            Description = "测试主机连通性",
            Icon = "\uE7F4",
            ViewInstance = new PingView(),
            ViewModel = _pingVM
        });

        Modules.Add(new ModuleItem
        {
            Key = "Traceroute",
            DisplayName = "Traceroute",
            Description = "逐跳追踪数据包路径",
            Icon = "\uE707",
            ViewInstance = new TracerouteView(),
            ViewModel = _tracerVM
        });

        SelectedModule = Modules[0];
    }
}
