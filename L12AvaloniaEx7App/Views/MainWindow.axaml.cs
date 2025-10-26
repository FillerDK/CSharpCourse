using Avalonia.Controls;
using Avalonia.Interactivity;

namespace L12AvaloniaEx7App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MenuItem_OnClick(object? sender, RoutedEventArgs e)
    {
        var item = (MenuItem)sender;
        
        TextBlock.Text = item.Header.ToString();
    }
}