using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace L12AvaloniaEx8App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RadioButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var radioButton = (RadioButton)sender;

        RadiobuttonStatus.Text = radioButton.Content.ToString();
    }
    
    private void CheckBox_OnClick(object? sender, RoutedEventArgs e)
    {
        var selected = new List<string>();
        
        if ((bool)chkLemon.IsChecked!) selected.Add("Lemon");
        if ((bool)chkOrange.IsChecked!) selected.Add("Orange");
        if ((bool)chkBanana.IsChecked!) selected.Add("Banana");

        ChekboxesStatus.Text = string.Join(",", selected);
    }
}