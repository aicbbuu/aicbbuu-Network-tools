using System.Windows;
using System.Windows.Controls;
using AicbbuuNetworkTools.ViewModels;

namespace AicbbuuNetworkTools.Views;

public partial class TracerouteView : UserControl
{
    public TracerouteView()
    {
        InitializeComponent();
    }

    private void Start_Click(object sender, RoutedEventArgs e)
    {
        if (DataContext is TracerouteViewModel vm)
            vm.StartTraceroute();
    }
}
