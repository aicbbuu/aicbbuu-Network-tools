using System.Windows;
using System.Windows.Input;
using AicbbuuNetworkTools.ViewModels;

namespace AicbbuuNetworkTools;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
