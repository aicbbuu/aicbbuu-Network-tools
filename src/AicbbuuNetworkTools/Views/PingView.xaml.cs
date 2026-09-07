using System.Windows;
using System.Windows.Controls;
using AicbbuuNetworkTools.ViewModels;

namespace AicbbuuNetworkTools.Views;

public partial class PingView : UserControl
{
    public PingView()
    {
        InitializeComponent();
    }

    private void Start_Click(object sender, RoutedEventArgs e)
    {
        if (DataContext is PingViewModel vm)
            vm.StartPing();
    }
}
