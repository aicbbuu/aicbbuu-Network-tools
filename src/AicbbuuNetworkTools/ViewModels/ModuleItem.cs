using CommunityToolkit.Mvvm.ComponentModel;
using AicbbuuNetworkTools.ViewModels;

namespace AicbbuuNetworkTools.ViewModels;

public sealed class ModuleItem : ObservableObject
{
    public string Key { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public object? ViewInstance { get; set; }
    public object? ViewModel { get; set; }
}
