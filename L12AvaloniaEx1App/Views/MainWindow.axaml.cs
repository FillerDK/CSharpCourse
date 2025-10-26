using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace L12AvaloniaApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Knap_OnClick(object? sender, RoutedEventArgs e)
    {
        ((Button)sender).Content = "Knap clicked";
    }

    private void ToggleButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var checkbox = ((CheckBox)sender);

        Button.IsVisible = (bool)checkbox.IsChecked;
    }
}